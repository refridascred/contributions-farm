-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, score, ratio) VALUES (28, 'blue', 14.18, 10.13);
INSERT INTO commits_records (rank, token, score, ratio) VALUES (95, 'edge', 41.86, 93.12);
INSERT INTO commits_records (rank, token, score, ratio) VALUES (42, 'stable', 67.78, 97.82);
