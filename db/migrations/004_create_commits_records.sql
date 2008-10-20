-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, count, score) VALUES ('local', 35, 49.61);
INSERT INTO commits_records (owner, count, score) VALUES ('primary', 50, 12.98);
INSERT INTO commits_records (owner, count, score) VALUES ('fallback', 18, 89.5);
