-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, rank, label, owner) VALUES (82.8, 46, 'fallback', 'stable');
INSERT INTO commits_records (score, rank, label, owner) VALUES (75.43, 94, 'eu-west', 'strict');
