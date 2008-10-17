-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, score, state, token) VALUES (86, 45.97, 'open', 'local');
INSERT INTO commits_records (rank, score, state, token) VALUES (62, 94.57, 'green', 'fallback');
