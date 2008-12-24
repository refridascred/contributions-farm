-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, ratio, owner, count, score) VALUES (81, 83.33, 'open', 67, 42.25);
INSERT INTO commits_records (rank, ratio, owner, count, score) VALUES (15, 29.45, 'legacy', 11, 41.6);
