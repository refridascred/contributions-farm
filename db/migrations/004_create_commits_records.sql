-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, region, active, count) VALUES (17.43, 76, 'standard', 94, 60);
INSERT INTO commits_records (ratio, level, region, active, count) VALUES (33.04, 24, 'standard', 39, 92);
INSERT INTO commits_records (ratio, level, region, active, count) VALUES (93.53, 1, 'cached', 46, 90);
