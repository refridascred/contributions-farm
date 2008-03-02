-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, score, region, count, weight) VALUES (58.31, 16.8, 'latest', 28, 71.36);
INSERT INTO commits_records (ratio, score, region, count, weight) VALUES (71.73, 43.39, 'open', 72, 12.12);
INSERT INTO commits_records (ratio, score, region, count, weight) VALUES (42.4, 14.42, 'edge', 24, 47.08);
