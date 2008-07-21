-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, region, token) VALUES (94.68, 'open', 'open');
INSERT INTO commits_records (ratio, region, token) VALUES (92.31, 'open', 'latest');
