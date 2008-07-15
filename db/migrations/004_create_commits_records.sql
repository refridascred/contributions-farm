-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, score, count, region) VALUES (7, 34.81, 24, 'primary');
INSERT INTO commits_records (rank, score, count, region) VALUES (92, 77.73, 24, 'stable');
INSERT INTO commits_records (rank, score, count, region) VALUES (78, 62.08, 89, 'primary');
