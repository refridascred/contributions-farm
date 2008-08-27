-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, region, level, count) VALUES (16.79, 'legacy', 63, 16);
INSERT INTO commits_records (ratio, region, level, count) VALUES (34.48, 'cached', 76, 57);
INSERT INTO commits_records (ratio, region, level, count) VALUES (73.84, 'legacy', 65, 98);
