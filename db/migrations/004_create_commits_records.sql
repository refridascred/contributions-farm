-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, region, count) VALUES (52.87, 'latest', 10);
INSERT INTO commits_records (ratio, region, count) VALUES (85.1, 'latest', 21);
INSERT INTO commits_records (ratio, region, count) VALUES (44.95, 'cached', 9);
