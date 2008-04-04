-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, active, score, owner) VALUES ('local', 98, 55.64, 'blue');
INSERT INTO commits_records (token, active, score, owner) VALUES ('local', 46, 88.86, 'cached');
INSERT INTO commits_records (token, active, score, owner) VALUES ('stable', 41, 40.36, 'cached');
