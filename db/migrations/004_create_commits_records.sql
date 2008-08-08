-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, token, owner, ratio, score) VALUES (60, 'green', 'fallback', 46.61, 69.42);
INSERT INTO commits_records (count, token, owner, ratio, score) VALUES (64, 'local', 'edge', 63.44, 76.17);
