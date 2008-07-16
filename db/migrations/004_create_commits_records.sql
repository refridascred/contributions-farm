-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, weight, rank, score, owner) VALUES (4, 16.54, 65, 97.55, 'legacy');
INSERT INTO commits_records (count, weight, rank, score, owner) VALUES (34, 9.5, 73, 64.47, 'local');
INSERT INTO commits_records (count, weight, rank, score, owner) VALUES (19, 19.36, 64, 4.12, 'open');
