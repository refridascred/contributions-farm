-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, score, rank, count) VALUES (98.89, 33.05, 32, 97);
INSERT INTO commits_records (weight, score, rank, count) VALUES (60.95, 76.59, 92, 68);
INSERT INTO commits_records (weight, score, rank, count) VALUES (48.14, 37.76, 98, 89);
