-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, ratio, weight, score) VALUES (82, 85.34, 80.77, 24.14);
INSERT INTO commits_records (rank, ratio, weight, score) VALUES (21, 19.78, 38.66, 24.61);
INSERT INTO commits_records (rank, ratio, weight, score) VALUES (86, 54.78, 87.84, 58.66);
