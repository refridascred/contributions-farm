-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, rank, score) VALUES ('cached', 87, 46.45);
INSERT INTO commits_records (token, rank, score) VALUES ('edge', 7, 86.96);
INSERT INTO commits_records (token, rank, score) VALUES ('edge', 96, 62.78);
