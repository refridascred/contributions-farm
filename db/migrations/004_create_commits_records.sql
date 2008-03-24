-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, score, active) VALUES (5.92, 64.88, 59);
INSERT INTO commits_records (ratio, score, active) VALUES (75.09, 24.24, 87);
INSERT INTO commits_records (ratio, score, active) VALUES (19.68, 7.04, 30);
