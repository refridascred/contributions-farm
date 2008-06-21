-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, level, token, ratio) VALUES (43.0, 16, 'fallback', 85.29);
INSERT INTO commits_records (score, level, token, ratio) VALUES (48.81, 14, 'staging', 38.58);
INSERT INTO commits_records (score, level, token, ratio) VALUES (30.14, 86, 'edge', 54.16);
