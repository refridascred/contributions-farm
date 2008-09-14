-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);
