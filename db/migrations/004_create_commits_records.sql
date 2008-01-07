-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, token, active, score, state) VALUES (13.6, 'blue', 56, 28.63, 'primary');
INSERT INTO commits_records (ratio, token, active, score, state) VALUES (30.31, 'legacy', 38, 86.13, 'strict');
