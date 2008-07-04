-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);
