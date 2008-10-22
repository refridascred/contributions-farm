-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, score, region, token, weight) VALUES (67.37, 53.94, 'latest', 'stable', 12.4);
