-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, region, count, owner, weight) VALUES (43.04, 'blue', 74, 'blue', 38.3);
INSERT INTO commits_records (ratio, region, count, owner, weight) VALUES (55.35, 'eu-west', 29, 'open', 93.7);
