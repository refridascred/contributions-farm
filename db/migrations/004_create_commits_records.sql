-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, ratio, owner, rank) VALUES (65.98, 58.31, 'green', 2);
INSERT INTO commits_records (score, ratio, owner, rank) VALUES (69.7, 31.96, 'fallback', 3);
INSERT INTO commits_records (score, ratio, owner, rank) VALUES (64.71, 41.98, 'latest', 99);
