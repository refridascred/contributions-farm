-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, weight, rank, count) VALUES (67.91, 14.9, 52, 43);
INSERT INTO commits_records (ratio, weight, rank, count) VALUES (37.41, 81.05, 3, 2);
