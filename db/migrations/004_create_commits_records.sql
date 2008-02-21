-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);
