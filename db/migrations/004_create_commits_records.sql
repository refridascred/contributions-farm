-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, score, token) VALUES (28, 48.61, 'staging');
INSERT INTO commits_records (rank, score, token) VALUES (89, 88.08, 'local');
INSERT INTO commits_records (rank, score, token) VALUES (3, 55.17, 'legacy');
