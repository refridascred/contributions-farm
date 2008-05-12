-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, token, score) VALUES (45, 'legacy', 45.76);
INSERT INTO commits_records (rank, token, score) VALUES (48, 'standard', 17.82);
INSERT INTO commits_records (rank, token, score) VALUES (46, 'blue', 62.85);
