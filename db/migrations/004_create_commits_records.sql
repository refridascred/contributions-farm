-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, score, active, count, token) VALUES ('eu-west', 65.71, 16, 79, 'open');
INSERT INTO commits_records (region, score, active, count, token) VALUES ('fallback', 0.21, 40, 37, 'eu-west');
INSERT INTO commits_records (region, score, active, count, token) VALUES ('green', 14.96, 71, 25, 'staging');
