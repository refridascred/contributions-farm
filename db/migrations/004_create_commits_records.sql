-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, rank, token, score, region) VALUES (82, 69, 'legacy', 39.93, 'blue');
INSERT INTO commits_records (level, rank, token, score, region) VALUES (66, 69, 'green', 5.2, 'latest');
