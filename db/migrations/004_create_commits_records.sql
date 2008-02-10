-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, score, rank, ratio, weight) VALUES ('local', 91.43, 70, 31.74, 35.17);
INSERT INTO commits_records (owner, score, rank, ratio, weight) VALUES ('latest', 41.52, 52, 38.08, 34.31);
INSERT INTO commits_records (owner, score, rank, ratio, weight) VALUES ('standard', 6.88, 94, 66.22, 62.19);
