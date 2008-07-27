-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, token, active, state, count) VALUES (14, 'green', 62, 'edge', 68);
INSERT INTO commits_records (rank, token, active, state, count) VALUES (16, 'open', 14, 'green', 13);
