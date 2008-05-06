-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, token, score, active, owner) VALUES (6, 'open', 98.56, 51, 'staging');
INSERT INTO commits_records (rank, token, score, active, owner) VALUES (12, 'legacy', 67.11, 25, 'eu-west');
