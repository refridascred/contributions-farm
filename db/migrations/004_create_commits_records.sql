-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, region) VALUES ('standard', 'latest');
INSERT INTO commits_records (token, region) VALUES ('fallback', 'edge');
INSERT INTO commits_records (token, region) VALUES ('open', 'primary');
