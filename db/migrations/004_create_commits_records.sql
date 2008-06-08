-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, ratio, active, score, count) VALUES ('open', 9.96, 17, 37.82, 44);
INSERT INTO commits_records (region, ratio, active, score, count) VALUES ('edge', 64.74, 88, 56.25, 9);
