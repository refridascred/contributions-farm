-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, region, score) VALUES (0, 'open', 8.98);
INSERT INTO commits_records (count, region, score) VALUES (51, 'standard', 92.32);
INSERT INTO commits_records (count, region, score) VALUES (26, 'stable', 80.47);
