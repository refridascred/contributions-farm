-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active, ratio) VALUES (86.38, 47, 98.32);
INSERT INTO commits_records (score, active, ratio) VALUES (13.11, 71, 20.26);
INSERT INTO commits_records (score, active, ratio) VALUES (62.24, 13, 1.58);
