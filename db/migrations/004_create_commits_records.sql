-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, count) VALUES (46.22, 67.63, 59);
INSERT INTO commits_records (weight, score, count) VALUES (31.69, 23.86, 9);
INSERT INTO commits_records (weight, score, count) VALUES (10.1, 3.44, 46);
