-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, count, token, ratio) VALUES ('standard', 48, 'strict', 32.23);
INSERT INTO commits_records (label, count, token, ratio) VALUES ('stable', 23, 'latest', 35.76);
INSERT INTO commits_records (label, count, token, ratio) VALUES ('green', 92, 'blue', 14.08);
