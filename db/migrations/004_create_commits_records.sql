-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, ratio, region, count, rank) VALUES (35.75, 30.13, 'green', 90, 17);
INSERT INTO commits_records (weight, ratio, region, count, rank) VALUES (85.92, 83.55, 'strict', 77, 93);
INSERT INTO commits_records (weight, ratio, region, count, rank) VALUES (88.72, 58.52, 'strict', 98, 88);
