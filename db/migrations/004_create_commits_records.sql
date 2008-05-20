-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, score, state, token) VALUES (70, 30.36, 'fallback', 'eu-west');
INSERT INTO commits_records (rank, score, state, token) VALUES (85, 88.84, 'stable', 'staging');
