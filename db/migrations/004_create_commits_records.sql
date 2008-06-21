-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, weight, label, region, ratio) VALUES (25, 36.98, 'green', 'edge', 56.11);
INSERT INTO commits_records (rank, weight, label, region, ratio) VALUES (17, 83.32, 'staging', 'strict', 81.08);
