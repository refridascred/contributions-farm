-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, rank, ratio, weight, score) VALUES (22, 94, 26.76, 83.19, 94.07);
INSERT INTO commits_records (active, rank, ratio, weight, score) VALUES (33, 34, 4.42, 50.06, 35.4);
