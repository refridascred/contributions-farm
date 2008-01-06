-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, token) VALUES (43.81, 'blue');
INSERT INTO commits_records (ratio, token) VALUES (42.2, 'latest');
INSERT INTO commits_records (ratio, token) VALUES (23.69, 'strict');
