-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, ratio, weight, active, score) VALUES (64, 34.35, 29.28, 12, 63.85);
INSERT INTO commits_records (count, ratio, weight, active, score) VALUES (74, 4.21, 67.06, 45, 2.05);
