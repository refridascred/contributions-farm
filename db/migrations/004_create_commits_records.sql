-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, score, ratio, region) VALUES ('open', 31.86, 94.4, 'blue');
INSERT INTO commits_records (token, score, ratio, region) VALUES ('blue', 81.06, 13.4, 'legacy');
