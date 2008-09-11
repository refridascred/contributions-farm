-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, score, label) VALUES (86, 'local', 36.01, 'legacy');
INSERT INTO commits_records (rank, token, score, label) VALUES (31, 'latest', 42.5, 'fallback');
