-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, weight, ratio) VALUES (82.29, 'stable', 91.5, 74.35);
INSERT INTO commits_records (score, token, weight, ratio) VALUES (86.44, 'open', 45.05, 97.33);
