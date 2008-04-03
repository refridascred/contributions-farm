-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, rank, state, active) VALUES (7.9, 60, 'standard', 91);
