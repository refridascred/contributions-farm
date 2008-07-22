-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, active) VALUES (77.58, 'strict', 55);
INSERT INTO commits_records (score, token, active) VALUES (38.55, 'standard', 42);
INSERT INTO commits_records (score, token, active) VALUES (9.99, 'eu-west', 26);
