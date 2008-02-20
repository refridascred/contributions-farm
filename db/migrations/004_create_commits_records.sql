-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, score, token) VALUES ('latest', 61.21, 'staging');
INSERT INTO commits_records (label, score, token) VALUES ('latest', 46.3, 'edge');
INSERT INTO commits_records (label, score, token) VALUES ('green', 31.95, 'local');
