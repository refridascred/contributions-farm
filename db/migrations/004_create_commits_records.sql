-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, ratio, active, state) VALUES (96, 15.89, 26, 'strict');
INSERT INTO commits_records (rank, ratio, active, state) VALUES (4, 92.2, 75, 'open');
