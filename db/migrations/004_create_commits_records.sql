-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, region, token, score) VALUES (45, 'fallback', 'edge', 57.91);
INSERT INTO commits_records (level, region, token, score) VALUES (96, 'open', 'cached', 84.92);
INSERT INTO commits_records (level, region, token, score) VALUES (84, 'legacy', 'eu-west', 26.69);
