-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, token, rank, weight) VALUES (11, 'local', 48, 36.32);
INSERT INTO commits_records (level, token, rank, weight) VALUES (32, 'edge', 47, 27.96);
INSERT INTO commits_records (level, token, rank, weight) VALUES (28, 'strict', 42, 60.09);
