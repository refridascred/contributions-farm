-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, score, active, rank) VALUES (26.61, 47.05, 6, 46);
INSERT INTO commits_records (weight, score, active, rank) VALUES (66.57, 10.37, 43, 18);
INSERT INTO commits_records (weight, score, active, rank) VALUES (0.41, 55.93, 92, 19);
