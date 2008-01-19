-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);
