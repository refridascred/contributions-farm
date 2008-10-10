-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, token, ratio, region, score) VALUES (23, 'blue', 47.23, 'stable', 19.52);
INSERT INTO commits_records (active, token, ratio, region, score) VALUES (38, 'fallback', 41.12, 'legacy', 34.24);
INSERT INTO commits_records (active, token, ratio, region, score) VALUES (85, 'eu-west', 42.43, 'local', 98.71);
