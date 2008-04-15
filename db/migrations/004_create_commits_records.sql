-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, ratio, region) VALUES (37, 53.09, 'staging');
INSERT INTO commits_records (count, ratio, region) VALUES (90, 89.0, 'legacy');
INSERT INTO commits_records (count, ratio, region) VALUES (57, 23.88, 'primary');
