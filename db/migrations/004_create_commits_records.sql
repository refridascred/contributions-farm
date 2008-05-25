-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region) VALUES (59.95, 'green');
INSERT INTO commits_records (ratio, region) VALUES (40.9, 'cached');
INSERT INTO commits_records (ratio, region) VALUES (48.27, 'strict');
