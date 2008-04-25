-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, region, label, score, active) VALUES (78, 'blue', 'fallback', 74.66, 81);
INSERT INTO commits_records (rank, region, label, score, active) VALUES (25, 'standard', 'legacy', 30.22, 24);
