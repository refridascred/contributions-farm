-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, token, active, state, weight) VALUES (12, 'legacy', 87, 'green', 17.64);
INSERT INTO commits_records (rank, token, active, state, weight) VALUES (10, 'fallback', 30, 'legacy', 4.9);
INSERT INTO commits_records (rank, token, active, state, weight) VALUES (39, 'edge', 85, 'latest', 18.93);
