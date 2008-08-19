-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, owner, label, score) VALUES ('staging', 'fallback', 'eu-west', 88.99);
INSERT INTO commits_records (token, owner, label, score) VALUES ('edge', 'latest', 'staging', 28.33);
