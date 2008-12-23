-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);
