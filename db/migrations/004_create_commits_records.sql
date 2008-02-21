-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);
