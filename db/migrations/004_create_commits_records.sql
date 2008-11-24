-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, weight, owner, score) VALUES (42, 'legacy', 5.99, 'strict', 22.77);
INSERT INTO commits_records (rank, token, weight, owner, score) VALUES (30, 'blue', 33.33, 'open', 38.5);
