-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, label, score, count) VALUES ('stable', 48, 'blue', 27.01, 8);
INSERT INTO commits_records (owner, rank, label, score, count) VALUES ('green', 6, 'eu-west', 70.77, 17);
INSERT INTO commits_records (owner, rank, label, score, count) VALUES ('strict', 10, 'edge', 7.66, 72);
