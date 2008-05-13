-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, count, region) VALUES (28, 66, 'strict');
INSERT INTO commits_records (rank, count, region) VALUES (14, 31, 'green');
INSERT INTO commits_records (rank, count, region) VALUES (65, 92, 'edge');
