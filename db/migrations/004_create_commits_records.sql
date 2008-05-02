-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, score, rank) VALUES (87.07, 22.79, 49);
INSERT INTO commits_records (weight, score, rank) VALUES (22.47, 88.8, 1);
INSERT INTO commits_records (weight, score, rank) VALUES (49.93, 70.63, 91);
