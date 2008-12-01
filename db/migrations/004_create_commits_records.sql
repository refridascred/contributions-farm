-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, ratio, region, count) VALUES (32, 73.65, 'standard', 6);
INSERT INTO commits_records (rank, ratio, region, count) VALUES (9, 76.97, 'eu-west', 47);
