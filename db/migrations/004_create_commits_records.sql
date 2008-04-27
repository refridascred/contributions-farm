-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);
