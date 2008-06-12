-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, ratio, region) VALUES (7, 88.71, 'cached');
INSERT INTO commits_records (count, ratio, region) VALUES (40, 51.19, 'open');
INSERT INTO commits_records (count, ratio, region) VALUES (29, 18.78, 'primary');
