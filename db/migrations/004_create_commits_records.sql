-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, ratio, score, token, region) VALUES (66, 8.91, 87.01, 'open', 'strict');
INSERT INTO commits_records (count, ratio, score, token, region) VALUES (62, 61.07, 30.17, 'fallback', 'local');
INSERT INTO commits_records (count, ratio, score, token, region) VALUES (4, 73.59, 19.28, 'green', 'strict');
