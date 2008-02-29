-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, ratio, active) VALUES (11, 89.94, 61.41, 47);
INSERT INTO commits_records (count, score, ratio, active) VALUES (86, 90.93, 87.35, 3);
