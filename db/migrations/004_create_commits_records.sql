-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, active, score, token, region) VALUES (63.4, 72, 0.1, 'blue', 'legacy');
INSERT INTO commits_records (weight, active, score, token, region) VALUES (60.81, 77, 72.8, 'staging', 'green');
INSERT INTO commits_records (weight, active, score, token, region) VALUES (48.37, 93, 29.83, 'cached', 'edge');
