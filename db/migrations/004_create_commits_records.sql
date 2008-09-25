-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, ratio, level) VALUES (85.27, 41.94, 56);
