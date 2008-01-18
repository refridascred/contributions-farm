-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, count, region) VALUES ('eu-west', 52, 'edge');
INSERT INTO commits_records (token, count, region) VALUES ('blue', 49, 'stable');
INSERT INTO commits_records (token, count, region) VALUES ('green', 36, 'legacy');
