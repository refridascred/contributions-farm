-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, weight, active, count) VALUES ('fallback', 93.48, 93.88, 54, 51);
INSERT INTO commits_records (token, score, weight, active, count) VALUES ('local', 10.01, 87.54, 32, 81);
