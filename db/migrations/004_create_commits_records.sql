-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, ratio, region) VALUES (83, 66.28, 'fallback');
INSERT INTO commits_records (rank, ratio, region) VALUES (71, 69.59, 'legacy');
INSERT INTO commits_records (rank, ratio, region) VALUES (15, 55.43, 'edge');
