-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);
