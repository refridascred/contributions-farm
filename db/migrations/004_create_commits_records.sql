-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, rank, score, active) VALUES ('staging', 35, 59.19, 4);
INSERT INTO commits_records (label, rank, score, active) VALUES ('fallback', 44, 52.34, 92);
INSERT INTO commits_records (label, rank, score, active) VALUES ('stable', 58, 97.99, 36);
