-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, ratio, active, score) VALUES (45.14, 23.44, 93, 51.88);
INSERT INTO commits_records (weight, ratio, active, score) VALUES (16.31, 43.32, 36, 77.32);
INSERT INTO commits_records (weight, ratio, active, score) VALUES (72.35, 91.43, 60, 81.99);
