-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, ratio, rank, region) VALUES (63.09, 31.83, 15, 'cached');
INSERT INTO commits_records (weight, ratio, rank, region) VALUES (16.67, 25.13, 38, 'stable');
INSERT INTO commits_records (weight, ratio, rank, region) VALUES (60.01, 41.28, 94, 'legacy');
