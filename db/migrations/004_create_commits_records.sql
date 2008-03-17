-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, weight, region) VALUES (4, 73.45, 82.68, 'latest');
INSERT INTO commits_records (count, score, weight, region) VALUES (72, 44.53, 56.67, 'fallback');
INSERT INTO commits_records (count, score, weight, region) VALUES (54, 3.72, 72.28, 'latest');
