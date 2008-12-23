-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, label, score, token) VALUES (74, 'latest', 62.59, 'local');
INSERT INTO commits_records (level, label, score, token) VALUES (80, 'eu-west', 21.16, 'edge');
INSERT INTO commits_records (level, label, score, token) VALUES (38, 'legacy', 68.69, 'open');
