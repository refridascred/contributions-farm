-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);
