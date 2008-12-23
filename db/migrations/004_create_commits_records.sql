-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, score, ratio, level) VALUES (41, 33.48, 39.76, 5);
INSERT INTO commits_records (active, score, ratio, level) VALUES (51, 14.9, 21.08, 99);
INSERT INTO commits_records (active, score, ratio, level) VALUES (18, 55.64, 72.14, 52);
