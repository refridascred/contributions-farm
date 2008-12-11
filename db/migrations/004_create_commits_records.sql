-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);
