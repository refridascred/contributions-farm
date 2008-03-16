-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, rank, weight, token) VALUES (46.58, 10, 12.99, 'cached');
INSERT INTO commits_records (ratio, rank, weight, token) VALUES (74.93, 5, 17.03, 'latest');
INSERT INTO commits_records (ratio, rank, weight, token) VALUES (41.07, 42, 33.72, 'strict');
