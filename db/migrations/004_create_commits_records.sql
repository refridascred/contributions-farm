-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, weight, region, count) VALUES (11.77, 90.51, 'local', 4);
INSERT INTO commits_records (score, weight, region, count) VALUES (20.96, 19.14, 'latest', 55);
INSERT INTO commits_records (score, weight, region, count) VALUES (57.57, 90.66, 'open', 57);
