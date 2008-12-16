-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, score, rank, ratio) VALUES (72, 71.69, 88, 28.98);
INSERT INTO commits_records (count, score, rank, ratio) VALUES (86, 74.57, 64, 63.2);
INSERT INTO commits_records (count, score, rank, ratio) VALUES (86, 27.47, 79, 72.82);
