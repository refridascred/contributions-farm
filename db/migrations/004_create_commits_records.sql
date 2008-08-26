-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, score, owner) VALUES ('stable', 30, 75.92, 'latest');
INSERT INTO commits_records (region, rank, score, owner) VALUES ('edge', 45, 33.35, 'latest');
