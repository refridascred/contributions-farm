-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, count, label, token) VALUES (21.01, 24, 'staging', 'blue');
