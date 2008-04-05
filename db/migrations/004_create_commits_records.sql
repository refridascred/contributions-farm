-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, count) VALUES (95.23, 93.22, 58);
INSERT INTO commits_records (weight, score, count) VALUES (79.45, 8.6, 39);
INSERT INTO commits_records (weight, score, count) VALUES (70.11, 98.04, 53);
