-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, score, label) VALUES ('legacy', 18.34, 76.73, 'local');
INSERT INTO commits_records (token, ratio, score, label) VALUES ('stable', 22.34, 94.51, 'local');
INSERT INTO commits_records (token, ratio, score, label) VALUES ('blue', 35.12, 22.42, 'edge');
