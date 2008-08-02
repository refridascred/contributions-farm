-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, label, weight) VALUES (96.38, 'eu-west', 'staging', 42.98);
INSERT INTO commits_records (score, token, label, weight) VALUES (36.57, 'standard', 'local', 52.16);
INSERT INTO commits_records (score, token, label, weight) VALUES (1.3, 'eu-west', 'open', 89.96);
