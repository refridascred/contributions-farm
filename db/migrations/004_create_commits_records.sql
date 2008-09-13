-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, ratio, region) VALUES (53, 43.01, 'eu-west');
INSERT INTO commits_records (count, ratio, region) VALUES (74, 13.88, 'local');
INSERT INTO commits_records (count, ratio, region) VALUES (19, 65.57, 'latest');
