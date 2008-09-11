-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, score, token) VALUES (62, 44.81, 'legacy');
INSERT INTO commits_records (rank, score, token) VALUES (15, 41.79, 'cached');
INSERT INTO commits_records (rank, score, token) VALUES (75, 1.9, 'edge');
