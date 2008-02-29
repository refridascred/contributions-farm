-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, owner, region) VALUES (1.08, 'edge', 'standard');
INSERT INTO commits_records (weight, owner, region) VALUES (86.98, 'staging', 'open');
INSERT INTO commits_records (weight, owner, region) VALUES (32.68, 'latest', 'eu-west');
