-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, ratio, score, count, active) VALUES (94.6, 23.05, 24.46, 6, 0);
INSERT INTO commits_records (weight, ratio, score, count, active) VALUES (22.39, 86.4, 88.84, 73, 47);
INSERT INTO commits_records (weight, ratio, score, count, active) VALUES (75.07, 80.92, 78.46, 80, 88);
