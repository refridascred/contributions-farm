-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);
