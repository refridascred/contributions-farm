-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, ratio, token, score, count) VALUES (93, 86.53, 'standard', 45.35, 96);
INSERT INTO commits_records (rank, ratio, token, score, count) VALUES (24, 50.78, 'staging', 19.24, 89);
