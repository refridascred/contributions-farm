-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, score, ratio) VALUES ('fallback', 13.11, 92.75);
INSERT INTO commits_records (owner, score, ratio) VALUES ('stable', 3.2, 89.9);
