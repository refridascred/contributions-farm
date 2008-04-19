-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, label, owner, token) VALUES (6.28, 'strict', 'stable', 'staging');
INSERT INTO commits_records (ratio, label, owner, token) VALUES (36.9, 'cached', 'blue', 'local');
