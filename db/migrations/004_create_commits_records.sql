-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, rank, region, level, ratio) VALUES (27, 30, 'stable', 56, 62.99);
INSERT INTO commits_records (count, rank, region, level, ratio) VALUES (42, 71, 'primary', 79, 43.77);
