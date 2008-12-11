-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, ratio, rank, token) VALUES (93.16, 82.65, 41, 'local');
INSERT INTO commits_records (score, ratio, rank, token) VALUES (13.99, 11.14, 50, 'green');
INSERT INTO commits_records (score, ratio, rank, token) VALUES (26.09, 46.18, 20, 'cached');
