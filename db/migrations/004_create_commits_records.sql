-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, label, weight, region) VALUES (50, 41.04, 'staging', 3.64, 'eu-west');
INSERT INTO commits_records (count, score, label, weight, region) VALUES (43, 33.25, 'strict', 86.14, 'strict');
