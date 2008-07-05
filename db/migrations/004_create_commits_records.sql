-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, ratio, state, token) VALUES (76, 22.92, 'legacy', 'local');
INSERT INTO commits_records (active, ratio, state, token) VALUES (0, 33.09, 'legacy', 'cached');
