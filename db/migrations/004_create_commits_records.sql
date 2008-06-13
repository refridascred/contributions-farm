-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, region, ratio, weight) VALUES (37, 'staging', 34.0, 25.3);
INSERT INTO commits_records (level, region, ratio, weight) VALUES (86, 'latest', 4.14, 22.89);
