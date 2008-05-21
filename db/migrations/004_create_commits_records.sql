-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, region, weight, owner) VALUES (61.76, 'staging', 34.83, 'strict');
INSERT INTO commits_records (score, region, weight, owner) VALUES (59.24, 'fallback', 41.67, 'legacy');
INSERT INTO commits_records (score, region, weight, owner) VALUES (14.81, 'open', 26.2, 'eu-west');
