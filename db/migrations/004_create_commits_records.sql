-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, ratio, score) VALUES (4, 52.14, 86.38);
INSERT INTO commits_records (rank, ratio, score) VALUES (19, 28.92, 3.24);
INSERT INTO commits_records (rank, ratio, score) VALUES (33, 59.76, 29.31);
