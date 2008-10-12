-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, weight, rank, score) VALUES (25, 8.21, 9, 44.9);
INSERT INTO commits_records (count, weight, rank, score) VALUES (11, 61.4, 99, 62.54);
INSERT INTO commits_records (count, weight, rank, score) VALUES (96, 34.7, 84, 55.48);
