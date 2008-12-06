-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);
