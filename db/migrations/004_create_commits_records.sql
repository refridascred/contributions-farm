-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, region, rank, ratio) VALUES (21.44, 'fallback', 98, 77.75);
INSERT INTO commits_records (weight, region, rank, ratio) VALUES (22.42, 'blue', 39, 63.61);
