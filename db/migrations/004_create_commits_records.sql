-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, level, label, token, region) VALUES (47.38, 72, 'legacy', 'standard', 'stable');
INSERT INTO commits_records (score, level, label, token, region) VALUES (5.12, 31, 'cached', 'local', 'eu-west');
