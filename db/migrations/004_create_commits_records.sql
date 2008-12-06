-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);
