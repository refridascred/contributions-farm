-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, score, token, active) VALUES (42, 49.38, 'local', 91);
INSERT INTO commits_records (level, score, token, active) VALUES (16, 20.9, 'staging', 12);
INSERT INTO commits_records (level, score, token, active) VALUES (1, 82.14, 'staging', 15);
