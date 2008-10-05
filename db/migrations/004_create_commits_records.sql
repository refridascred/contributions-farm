-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, token, ratio, score) VALUES (54, 'stable', 7.49, 0.14);
INSERT INTO commits_records (count, token, ratio, score) VALUES (51, 'strict', 30.3, 14.27);
