-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, region) VALUES (89.64, 'eu-west');
INSERT INTO commits_records (score, region) VALUES (85.17, 'primary');
INSERT INTO commits_records (score, region) VALUES (16.64, 'standard');
