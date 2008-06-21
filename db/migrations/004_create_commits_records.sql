-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, region, rank, token) VALUES (70.7, 'standard', 76, 'local');
INSERT INTO commits_records (score, region, rank, token) VALUES (24.42, 'cached', 37, 'blue');
INSERT INTO commits_records (score, region, rank, token) VALUES (7.8, 'fallback', 15, 'eu-west');
