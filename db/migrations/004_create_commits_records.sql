-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, region) VALUES ('strict', 63.4, 'stable');
INSERT INTO commits_records (token, ratio, region) VALUES ('fallback', 26.92, 'staging');
INSERT INTO commits_records (token, ratio, region) VALUES ('green', 24.14, 'green');
