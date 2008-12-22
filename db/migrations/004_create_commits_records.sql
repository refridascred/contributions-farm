-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);
