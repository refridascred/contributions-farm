-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, label, count, score) VALUES ('cached', 'stable', 3, 43.6);
INSERT INTO commits_records (owner, label, count, score) VALUES ('standard', 'latest', 51, 43.8);
INSERT INTO commits_records (owner, label, count, score) VALUES ('primary', 'stable', 42, 89.3);
