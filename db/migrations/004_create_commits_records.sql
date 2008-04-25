-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, token, score, region) VALUES (10, 'legacy', 3.29, 'fallback');
INSERT INTO commits_records (active, token, score, region) VALUES (43, 'eu-west', 73.16, 'open');
INSERT INTO commits_records (active, token, score, region) VALUES (26, 'staging', 42.99, 'green');
