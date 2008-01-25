-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, owner, score, token) VALUES (45, 'legacy', 59.45, 'open');
INSERT INTO commits_records (rank, owner, score, token) VALUES (91, 'standard', 31.51, 'eu-west');
INSERT INTO commits_records (rank, owner, score, token) VALUES (41, 'fallback', 49.8, 'strict');
