-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, count, score, active) VALUES (90.24, 8, 18.31, 73);
INSERT INTO commits_records (ratio, count, score, active) VALUES (77.4, 55, 71.79, 72);
INSERT INTO commits_records (ratio, count, score, active) VALUES (39.19, 63, 57.18, 68);
