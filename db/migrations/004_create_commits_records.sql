-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, weight, region, level) VALUES (49, 65.32, 'stable', 80);
INSERT INTO commits_records (count, weight, region, level) VALUES (85, 45.01, 'latest', 96);
