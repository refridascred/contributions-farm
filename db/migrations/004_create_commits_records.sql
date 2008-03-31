-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, rank, ratio, count) VALUES (30, 'standard', 46, 44.05, 84);
INSERT INTO commits_records (active, region, rank, ratio, count) VALUES (96, 'green', 71, 78.62, 51);
INSERT INTO commits_records (active, region, rank, ratio, count) VALUES (51, 'stable', 78, 65.67, 3);
