-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, label, region) VALUES (87, 'staging', 'green');
INSERT INTO commits_records (count, label, region) VALUES (80, 'latest', 'stable');
INSERT INTO commits_records (count, label, region) VALUES (59, 'local', 'standard');
