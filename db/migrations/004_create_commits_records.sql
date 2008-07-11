-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, ratio, weight, count, score) VALUES (0, 16.88, 8.12, 97, 39.94);
INSERT INTO commits_records (rank, ratio, weight, count, score) VALUES (18, 96.13, 62.94, 33, 72.73);
INSERT INTO commits_records (rank, ratio, weight, count, score) VALUES (49, 20.36, 68.52, 99, 15.89);
