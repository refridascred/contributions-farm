-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, token, ratio, label) VALUES (35.33, 'latest', 91.75, 'legacy');
INSERT INTO commits_records (score, token, ratio, label) VALUES (24.39, 'cached', 86.73, 'local');
INSERT INTO commits_records (score, token, ratio, label) VALUES (52.12, 'latest', 76.72, 'strict');
