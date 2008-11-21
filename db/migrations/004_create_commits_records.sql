-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);
