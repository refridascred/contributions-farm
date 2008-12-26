-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, score, token, region, active) VALUES (33, 10.09, 'eu-west', 'staging', 10);
INSERT INTO commits_records (level, score, token, region, active) VALUES (5, 76.88, 'eu-west', 'strict', 76);
