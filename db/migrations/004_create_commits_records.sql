-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, count, state, weight) VALUES (2, 'strict', 11, 'edge', 79.56);
INSERT INTO commits_records (rank, token, count, state, weight) VALUES (2, 'latest', 55, 'blue', 62.01);
INSERT INTO commits_records (rank, token, count, state, weight) VALUES (10, 'green', 53, 'legacy', 45.4);
