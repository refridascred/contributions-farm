-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, score, count) VALUES (50.74, 'green', 11.81, 61);
INSERT INTO commits_records (weight, region, score, count) VALUES (89.02, 'eu-west', 65.79, 29);
INSERT INTO commits_records (weight, region, score, count) VALUES (96.68, 'open', 86.33, 70);
