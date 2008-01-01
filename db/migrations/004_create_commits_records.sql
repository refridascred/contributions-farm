-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, ratio, weight) VALUES ('open', 2, 56.09, 49.27);
