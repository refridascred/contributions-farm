-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, weight, score, rank) VALUES (6.0, 9.75, 19.36, 30);
INSERT INTO commits_records (ratio, weight, score, rank) VALUES (58.48, 42.39, 13.76, 35);
INSERT INTO commits_records (ratio, weight, score, rank) VALUES (4.36, 9.02, 57.2, 70);
