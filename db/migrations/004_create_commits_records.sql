-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, weight, ratio) VALUES ('edge', 44, 98.72, 11.92);
INSERT INTO commits_records (region, rank, weight, ratio) VALUES ('local', 39, 39.08, 94.48);
