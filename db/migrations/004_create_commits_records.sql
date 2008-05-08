-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, score, ratio, region) VALUES (53, 67.28, 93.1, 'fallback');
INSERT INTO commits_records (rank, score, ratio, region) VALUES (8, 94.5, 33.38, 'edge');
INSERT INTO commits_records (rank, score, ratio, region) VALUES (74, 38.66, 16.6, 'open');
