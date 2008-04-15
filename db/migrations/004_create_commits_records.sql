-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, region, owner, count, score) VALUES (78.58, 'latest', 'blue', 12, 97.17);
INSERT INTO commits_records (weight, region, owner, count, score) VALUES (11.34, 'primary', 'edge', 25, 28.05);
