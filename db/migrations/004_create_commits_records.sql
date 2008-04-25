-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, count, score, ratio, rank) VALUES (60.31, 98, 45.63, 14.29, 92);
INSERT INTO commits_records (weight, count, score, ratio, rank) VALUES (62.37, 12, 22.69, 59.51, 54);
