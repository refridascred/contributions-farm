-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, ratio, score, region, owner) VALUES (38.23, 85.94, 24.88, 'staging', 'standard');
INSERT INTO commits_records (weight, ratio, score, region, owner) VALUES (65.94, 1.32, 61.94, 'fallback', 'eu-west');
INSERT INTO commits_records (weight, ratio, score, region, owner) VALUES (2.82, 70.19, 84.79, 'staging', 'standard');
