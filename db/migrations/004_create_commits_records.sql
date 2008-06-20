-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, active, owner, token) VALUES (33.24, 47, 'fallback', 'blue');
INSERT INTO commits_records (weight, active, owner, token) VALUES (21.22, 56, 'fallback', 'green');
INSERT INTO commits_records (weight, active, owner, token) VALUES (39.76, 40, 'stable', 'eu-west');
