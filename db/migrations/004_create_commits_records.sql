-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);
