-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, region) VALUES (80, 'strict');
INSERT INTO commits_records (count, region) VALUES (62, 'eu-west');
INSERT INTO commits_records (count, region) VALUES (86, 'standard');
