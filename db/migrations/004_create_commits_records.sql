-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);
