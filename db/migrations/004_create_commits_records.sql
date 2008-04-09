-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, owner, score, level, count) VALUES (14, 'staging', 79.41, 94, 98);
INSERT INTO commits_records (rank, owner, score, level, count) VALUES (25, 'open', 46.63, 50, 33);
INSERT INTO commits_records (rank, owner, score, level, count) VALUES (92, 'cached', 70.84, 76, 58);
