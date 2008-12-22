-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, region, count, weight, score) VALUES (15, 'strict', 38, 46.57, 93.26);
INSERT INTO commits_records (rank, region, count, weight, score) VALUES (19, 'latest', 34, 29.91, 82.3);
