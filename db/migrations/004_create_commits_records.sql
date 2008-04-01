-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, ratio, region, token) VALUES (76, 97.14, 'strict', 'strict');
INSERT INTO commits_records (level, ratio, region, token) VALUES (84, 24.07, 'fallback', 'edge');
