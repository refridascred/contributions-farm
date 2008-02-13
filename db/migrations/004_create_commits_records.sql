-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);
