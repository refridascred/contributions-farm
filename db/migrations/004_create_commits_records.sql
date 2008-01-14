-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, count, label, owner) VALUES (14.11, 16, 'stable', 'local');
INSERT INTO commits_records (score, count, label, owner) VALUES (21.41, 70, 'fallback', 'green');
INSERT INTO commits_records (score, count, label, owner) VALUES (28.77, 6, 'edge', 'blue');
