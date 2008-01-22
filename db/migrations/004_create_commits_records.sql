-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, token, score) VALUES (41.27, 'staging', 32.33);
INSERT INTO commits_records (ratio, token, score) VALUES (29.13, 'stable', 44.08);
INSERT INTO commits_records (ratio, token, score) VALUES (14.63, 'open', 86.4);
