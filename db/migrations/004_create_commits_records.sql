-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, ratio, region) VALUES (79, 82.58, 'fallback');
INSERT INTO commits_records (level, ratio, region) VALUES (74, 16.64, 'eu-west');
INSERT INTO commits_records (level, ratio, region) VALUES (25, 0.23, 'edge');
