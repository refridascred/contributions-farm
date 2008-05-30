-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, active, count) VALUES ('edge', 5.16, 39, 12);
INSERT INTO commits_records (token, score, active, count) VALUES ('open', 31.01, 42, 51);
INSERT INTO commits_records (token, score, active, count) VALUES ('latest', 30.36, 69, 12);
