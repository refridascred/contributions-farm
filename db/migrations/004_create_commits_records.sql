-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, rank, token) VALUES (1.76, 99, 'stable');
INSERT INTO commits_records (weight, rank, token) VALUES (36.85, 72, 'latest');
