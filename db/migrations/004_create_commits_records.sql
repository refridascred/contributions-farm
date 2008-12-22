-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, weight, region, ratio) VALUES (52, 60.57, 'latest', 33.78);
INSERT INTO commits_records (rank, weight, region, ratio) VALUES (67, 52.69, 'stable', 40.41);
INSERT INTO commits_records (rank, weight, region, ratio) VALUES (94, 10.41, 'stable', 27.4);
