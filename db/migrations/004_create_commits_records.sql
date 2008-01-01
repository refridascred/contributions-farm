-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, rank, token) VALUES (96.85, 72, 'latest');
INSERT INTO commits_records (score, rank, token) VALUES (77.31, 89, 'green');
INSERT INTO commits_records (score, rank, token) VALUES (81.22, 47, 'fallback');
