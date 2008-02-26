-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, count, score, active) VALUES ('strict', 92, 3.6, 23);
INSERT INTO commits_records (owner, count, score, active) VALUES ('eu-west', 36, 30.3, 23);
INSERT INTO commits_records (owner, count, score, active) VALUES ('eu-west', 8, 55.04, 14);
