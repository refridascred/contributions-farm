-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, active, count, ratio) VALUES (22.65, 32, 86, 59.99);
INSERT INTO commits_records (score, active, count, ratio) VALUES (51.86, 38, 52, 43.48);
INSERT INTO commits_records (score, active, count, ratio) VALUES (52.0, 41, 11, 71.8);
