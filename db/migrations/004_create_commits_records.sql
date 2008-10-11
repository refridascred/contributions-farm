-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (state, rank, region, score) VALUES ('stable', 13, 'strict', 51.83);
INSERT INTO commits_records (state, rank, region, score) VALUES ('edge', 61, 'legacy', 59.41);
INSERT INTO commits_records (state, rank, region, score) VALUES ('strict', 5, 'staging', 49.25);
