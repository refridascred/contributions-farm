-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, score, token) VALUES (11, 1.07, 'stable');
INSERT INTO commits_records (active, score, token) VALUES (32, 14.93, 'primary');
INSERT INTO commits_records (active, score, token) VALUES (35, 40.33, 'cached');
