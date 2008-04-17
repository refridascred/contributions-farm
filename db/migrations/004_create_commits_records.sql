-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, token, ratio) VALUES (65, 'fallback', 84.48);
INSERT INTO commits_records (rank, token, ratio) VALUES (60, 'legacy', 34.82);
INSERT INTO commits_records (rank, token, ratio) VALUES (28, 'stable', 54.66);
