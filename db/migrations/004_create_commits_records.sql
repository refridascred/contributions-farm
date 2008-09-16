-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, weight, ratio, count) VALUES (65, 80.1, 79.08, 14);
INSERT INTO commits_records (rank, weight, ratio, count) VALUES (44, 48.05, 91.53, 40);
INSERT INTO commits_records (rank, weight, ratio, count) VALUES (31, 83.88, 62.74, 68);
