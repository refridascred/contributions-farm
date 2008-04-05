-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, count, region) VALUES (13, 12.16, 30, 'edge');
INSERT INTO commits_records (level, ratio, count, region) VALUES (14, 23.48, 2, 'strict');
INSERT INTO commits_records (level, ratio, count, region) VALUES (9, 28.7, 74, 'edge');
