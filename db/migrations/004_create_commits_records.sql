-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, active, score, count) VALUES ('local', 62, 90.49, 7);
INSERT INTO commits_records (owner, active, score, count) VALUES ('fallback', 73, 21.85, 69);
INSERT INTO commits_records (owner, active, score, count) VALUES ('eu-west', 60, 29.58, 88);
