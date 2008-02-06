-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, region) VALUES (93.34, 84.99, 'strict');
INSERT INTO commits_records (weight, score, region) VALUES (32.32, 28.57, 'green');
