-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, ratio, token, active) VALUES ('fallback', 78.03, 'standard', 16);
INSERT INTO commits_records (owner, ratio, token, active) VALUES ('standard', 97.73, 'staging', 65);
INSERT INTO commits_records (owner, ratio, token, active) VALUES ('eu-west', 76.72, 'latest', 48);
