-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, region, count) VALUES (16.56, 'staging', 47);
INSERT INTO commits_records (weight, region, count) VALUES (94.7, 'fallback', 4);
INSERT INTO commits_records (weight, region, count) VALUES (49.04, 'strict', 11);
