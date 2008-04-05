-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, token, ratio, count) VALUES ('edge', 'fallback', 42.57, 97);
INSERT INTO commits_records (region, token, ratio, count) VALUES ('fallback', 'edge', 34.94, 38);
