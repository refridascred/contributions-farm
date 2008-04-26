-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, count, score, region) VALUES (86, 3, 55.04, 'stable');
INSERT INTO commits_records (rank, count, score, region) VALUES (33, 50, 49.38, 'latest');
INSERT INTO commits_records (rank, count, score, region) VALUES (65, 55, 10.28, 'fallback');
