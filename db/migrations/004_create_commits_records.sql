-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, region, count) VALUES (93.36, 'staging', 16);
INSERT INTO commits_records (ratio, region, count) VALUES (32.91, 'eu-west', 67);
INSERT INTO commits_records (ratio, region, count) VALUES (68.87, 'latest', 56);
