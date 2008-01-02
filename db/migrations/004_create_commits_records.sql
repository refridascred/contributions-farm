-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, region, weight) VALUES (22.23, 'legacy', 29.26);
INSERT INTO commits_records (ratio, region, weight) VALUES (40.18, 'staging', 76.02);
