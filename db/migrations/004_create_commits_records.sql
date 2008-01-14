-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, region, rank, ratio) VALUES (94, 'stable', 33, 72.93);
INSERT INTO commits_records (level, region, rank, ratio) VALUES (68, 'cached', 94, 90.31);
