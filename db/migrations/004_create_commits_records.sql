-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, label, score, count, rank) VALUES ('blue', 'primary', 48.18, 47, 7);
INSERT INTO commits_records (token, label, score, count, rank) VALUES ('edge', 'green', 39.59, 8, 7);
