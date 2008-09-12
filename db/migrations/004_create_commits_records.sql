-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, rank, owner, ratio) VALUES (51, 10, 'green', 69.44);
INSERT INTO commits_records (count, rank, owner, ratio) VALUES (45, 32, 'latest', 92.86);
INSERT INTO commits_records (count, rank, owner, ratio) VALUES (73, 30, 'edge', 94.08);
