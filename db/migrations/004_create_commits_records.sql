-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, level) VALUES (49.24, 'latest', 34);
INSERT INTO commits_records (score, token, level) VALUES (20.73, 'standard', 52);
INSERT INTO commits_records (score, token, level) VALUES (23.83, 'legacy', 62);
