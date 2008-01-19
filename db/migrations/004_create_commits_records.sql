-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, weight, count, token) VALUES ('staging', 76.74, 88, 'green');
INSERT INTO commits_records (label, weight, count, token) VALUES ('fallback', 66.31, 16, 'blue');
