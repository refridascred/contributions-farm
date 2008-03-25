-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, owner, token) VALUES (28.5, 'legacy', 'local');
INSERT INTO commits_records (weight, owner, token) VALUES (94.34, 'fallback', 'stable');
