-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, label, rank, active) VALUES (89.05, 'fallback', 95, 99);
INSERT INTO commits_records (score, label, rank, active) VALUES (10.55, 'edge', 42, 32);
INSERT INTO commits_records (score, label, rank, active) VALUES (10.77, 'staging', 43, 68);
