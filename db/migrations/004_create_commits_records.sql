-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token) VALUES (57.95, 'strict');
INSERT INTO commits_records (weight, token) VALUES (29.58, 'green');
INSERT INTO commits_records (weight, token) VALUES (64.92, 'fallback');
