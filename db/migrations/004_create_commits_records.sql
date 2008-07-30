-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, score, token, label) VALUES (17, 83.69, 'staging', 'blue');
INSERT INTO commits_records (level, score, token, label) VALUES (44, 59.59, 'latest', 'stable');
INSERT INTO commits_records (level, score, token, label) VALUES (59, 54.21, 'legacy', 'legacy');
