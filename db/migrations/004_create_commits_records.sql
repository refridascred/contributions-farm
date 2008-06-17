-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, owner) VALUES (52.86, 35.48, 'standard');
INSERT INTO commits_records (score, ratio, owner) VALUES (24.76, 50.86, 'fallback');
INSERT INTO commits_records (score, ratio, owner) VALUES (61.17, 60.02, 'staging');
