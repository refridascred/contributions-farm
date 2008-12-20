-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, region, weight, level) VALUES (72, 'legacy', 21.59, 8);
INSERT INTO commits_records (rank, region, weight, level) VALUES (60, 'edge', 76.06, 27);
INSERT INTO commits_records (rank, region, weight, level) VALUES (74, 'green', 62.6, 60);
