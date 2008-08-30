-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, score, weight, ratio, count) VALUES (15, 79.4, 55.65, 44.95, 81);
INSERT INTO commits_records (rank, score, weight, ratio, count) VALUES (69, 20.31, 94.27, 36.19, 13);
INSERT INTO commits_records (rank, score, weight, ratio, count) VALUES (14, 3.9, 71.97, 18.77, 21);
