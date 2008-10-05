-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, score, owner) VALUES ('blue', 29.66, 'local');
INSERT INTO commits_records (region, score, owner) VALUES ('fallback', 25.53, 'cached');
INSERT INTO commits_records (region, score, owner) VALUES ('standard', 0.39, 'legacy');
