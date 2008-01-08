-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, ratio, rank) VALUES (9.01, 64.78, 22.72, 70);
INSERT INTO commits_records (weight, score, ratio, rank) VALUES (2.86, 24.68, 66.84, 89);
INSERT INTO commits_records (weight, score, ratio, rank) VALUES (13.5, 39.06, 5.59, 9);
