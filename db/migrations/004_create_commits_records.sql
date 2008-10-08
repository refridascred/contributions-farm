-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, ratio, score, token) VALUES (69, 12.37, 54.07, 'local');
INSERT INTO commits_records (rank, ratio, score, token) VALUES (33, 39.88, 33.14, 'latest');
INSERT INTO commits_records (rank, ratio, score, token) VALUES (94, 13.22, 89.72, 'latest');
