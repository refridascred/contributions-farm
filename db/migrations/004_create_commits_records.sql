-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, count, region) VALUES (67.87, 20, 'cached');
INSERT INTO commits_records (ratio, count, region) VALUES (20.83, 71, 'staging');
