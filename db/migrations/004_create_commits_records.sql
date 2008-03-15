-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, token, score, active) VALUES (25.05, 'latest', 8.81, 33);
INSERT INTO commits_records (weight, token, score, active) VALUES (63.56, 'green', 30.95, 56);
