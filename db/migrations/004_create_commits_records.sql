-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token) VALUES (13.99, 'cached');
INSERT INTO commits_records (weight, token) VALUES (58.59, 'stable');
INSERT INTO commits_records (weight, token) VALUES (61.34, 'edge');
