-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, region) VALUES (5.78, 'primary');
INSERT INTO commits_records (ratio, region) VALUES (37.13, 'staging');
INSERT INTO commits_records (ratio, region) VALUES (43.34, 'primary');
