-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, token, ratio, region) VALUES (85, 'primary', 29.93, 'strict');
INSERT INTO commits_records (level, token, ratio, region) VALUES (42, 'edge', 58.24, 'eu-west');
