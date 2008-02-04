-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, score, rank, ratio, weight) VALUES (5, 48.65, 23, 1.26, 69.63);
INSERT INTO commits_records (count, score, rank, ratio, weight) VALUES (41, 40.47, 7, 15.43, 53.43);
INSERT INTO commits_records (count, score, rank, ratio, weight) VALUES (62, 79.67, 65, 77.08, 21.3);
