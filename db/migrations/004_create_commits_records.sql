-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, score, active) VALUES (94.05, 39.6, 99);
INSERT INTO commits_records (ratio, score, active) VALUES (98.13, 30.88, 36);
INSERT INTO commits_records (ratio, score, active) VALUES (52.1, 22.78, 45);
