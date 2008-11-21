-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, active) VALUES (53.17, 'green', 70);
INSERT INTO commits_records (score, token, active) VALUES (45.07, 'standard', 7);
INSERT INTO commits_records (score, token, active) VALUES (69.96, 'primary', 97);
