-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);
