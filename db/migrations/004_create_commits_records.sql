-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, score, region, label, active) VALUES (7, 37.76, 'edge', 'staging', 21);
INSERT INTO commits_records (rank, score, region, label, active) VALUES (78, 37.49, 'blue', 'fallback', 24);
INSERT INTO commits_records (rank, score, region, label, active) VALUES (14, 74.19, 'fallback', 'strict', 92);
