-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);
