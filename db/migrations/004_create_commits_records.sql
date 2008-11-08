-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, region, owner, rank, count) VALUES (11.27, 'green', 'strict', 33, 3);
INSERT INTO commits_records (score, region, owner, rank, count) VALUES (14.57, 'edge', 'eu-west', 42, 63);
