-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, level) VALUES (75.51, 'edge', 77);
INSERT INTO commits_records (score, token, level) VALUES (10.85, 'cached', 78);
INSERT INTO commits_records (score, token, level) VALUES (46.03, 'open', 1);
