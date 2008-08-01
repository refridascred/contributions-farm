-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, region, weight, count) VALUES (61, 'cached', 62.19, 0);
INSERT INTO commits_records (rank, region, weight, count) VALUES (13, 'stable', 34.42, 17);
