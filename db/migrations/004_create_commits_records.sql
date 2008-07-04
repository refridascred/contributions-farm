-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region) VALUES (16.41, 'cached');
INSERT INTO commits_records (weight, region) VALUES (13.83, 'staging');
INSERT INTO commits_records (weight, region) VALUES (42.8, 'open');
