-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);
