-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, weight, region, score) VALUES (14.52, 53.06, 'legacy', 37.11);
INSERT INTO commits_records (ratio, weight, region, score) VALUES (48.01, 25.17, 'standard', 74.06);
INSERT INTO commits_records (ratio, weight, region, score) VALUES (20.57, 23.52, 'latest', 15.4);
