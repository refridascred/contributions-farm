-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, token, region) VALUES (69, 'fallback', 'edge');
INSERT INTO commits_records (level, token, region) VALUES (44, 'green', 'open');
INSERT INTO commits_records (level, token, region) VALUES (94, 'standard', 'open');
