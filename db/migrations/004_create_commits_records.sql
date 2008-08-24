-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, token, state, count, owner) VALUES (66.58, 'green', 'primary', 8, 'standard');
INSERT INTO commits_records (score, token, state, count, owner) VALUES (82.99, 'edge', 'local', 66, 'standard');
