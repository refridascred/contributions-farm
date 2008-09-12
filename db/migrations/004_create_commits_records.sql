-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, count, region) VALUES (40, 8, 'cached');
INSERT INTO commits_records (active, count, region) VALUES (63, 45, 'latest');
INSERT INTO commits_records (active, count, region) VALUES (65, 62, 'staging');
