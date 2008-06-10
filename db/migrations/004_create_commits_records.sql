-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);
