-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, active, label) VALUES ('blue', 39.99, 12, 'stable');
INSERT INTO commits_records (token, score, active, label) VALUES ('latest', 97.36, 6, 'latest');
INSERT INTO commits_records (token, score, active, label) VALUES ('local', 71.34, 88, 'edge');
