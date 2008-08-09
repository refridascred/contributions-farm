-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, level, ratio, region) VALUES (9, 36, 0.88, 'legacy');
INSERT INTO commits_records (count, level, ratio, region) VALUES (33, 94, 0.74, 'edge');
