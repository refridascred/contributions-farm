-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, rank, token) VALUES (47.9, 89, 'legacy');
INSERT INTO commits_records (weight, rank, token) VALUES (20.54, 16, 'primary');
