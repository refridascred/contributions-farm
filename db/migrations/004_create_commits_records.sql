-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, region, count, token, weight) VALUES (78.57, 'edge', 24, 'primary', 12.45);
INSERT INTO commits_records (ratio, region, count, token, weight) VALUES (52.29, 'staging', 96, 'local', 23.81);
