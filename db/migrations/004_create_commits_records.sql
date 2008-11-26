-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, score, rank) VALUES (90, 89.44, 72);
INSERT INTO commits_records (count, score, rank) VALUES (85, 28.76, 47);
INSERT INTO commits_records (count, score, rank) VALUES (19, 9.67, 41);
