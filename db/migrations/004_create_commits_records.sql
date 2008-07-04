-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, count, token, score, ratio) VALUES ('standard', 69, 'staging', 95.01, 90.55);
INSERT INTO commits_records (owner, count, token, score, ratio) VALUES ('edge', 83, 'edge', 86.63, 80.93);
