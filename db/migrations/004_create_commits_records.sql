-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank, owner, score, count) VALUES (19, 49, 'primary', 73.9, 2);
INSERT INTO commits_records (active, rank, owner, score, count) VALUES (24, 60, 'green', 17.61, 51);
INSERT INTO commits_records (active, rank, owner, score, count) VALUES (90, 38, 'open', 74.96, 92);
