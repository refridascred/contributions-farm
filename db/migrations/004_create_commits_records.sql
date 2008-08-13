-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, owner, region, count) VALUES (16.12, 'edge', 'blue', 60);
INSERT INTO commits_records (ratio, owner, region, count) VALUES (5.64, 'edge', 'stable', 88);
INSERT INTO commits_records (ratio, owner, region, count) VALUES (43.49, 'fallback', 'eu-west', 2);
