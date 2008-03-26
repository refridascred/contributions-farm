-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, owner, ratio, level, region) VALUES (44, 'legacy', 30.8, 58, 'staging');
INSERT INTO commits_records (count, owner, ratio, level, region) VALUES (18, 'strict', 2.29, 25, 'stable');
