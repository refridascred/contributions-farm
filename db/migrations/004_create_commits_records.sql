-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, score) VALUES ('green', 1.59);
INSERT INTO commits_records (region, score) VALUES ('staging', 44.24);
INSERT INTO commits_records (region, score) VALUES ('local', 36.24);
