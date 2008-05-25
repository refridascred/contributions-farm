-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, owner, rank, token) VALUES (7.47, 30.66, 'edge', 10, 'open');
INSERT INTO commits_records (weight, score, owner, rank, token) VALUES (84.69, 82.02, 'latest', 55, 'open');
