-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, label, score) VALUES ('latest', 'latest', 2.47);
INSERT INTO commits_records (token, label, score) VALUES ('edge', 'fallback', 72.11);
INSERT INTO commits_records (token, label, score) VALUES ('stable', 'blue', 87.75);
