-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, owner, ratio, level) VALUES ('strict', 'green', 1.45, 75);
INSERT INTO commits_records (region, owner, ratio, level) VALUES ('edge', 'open', 5.58, 98);
INSERT INTO commits_records (region, owner, ratio, level) VALUES ('green', 'strict', 13.87, 85);
