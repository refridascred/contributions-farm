-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, count, region) VALUES (85.75, 24, 'legacy');
INSERT INTO commits_records (ratio, count, region) VALUES (81.6, 61, 'fallback');
INSERT INTO commits_records (ratio, count, region) VALUES (96.04, 44, 'local');
