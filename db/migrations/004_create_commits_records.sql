-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, count, region, level, label) VALUES (64.43, 8, 'stable', 26, 'cached');
INSERT INTO commits_records (ratio, count, region, level, label) VALUES (28.12, 13, 'latest', 0, 'local');
INSERT INTO commits_records (ratio, count, region, level, label) VALUES (34.75, 56, 'strict', 62, 'standard');
