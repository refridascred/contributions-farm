-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, label) VALUES (8.7, 'staging', 'latest');
INSERT INTO commits_records (weight, region, label) VALUES (71.33, 'eu-west', 'standard');
INSERT INTO commits_records (weight, region, label) VALUES (67.98, 'fallback', 'open');
