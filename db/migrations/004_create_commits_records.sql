-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, region, ratio, active, score) VALUES (19, 'standard', 7.1, 25, 1.99);
INSERT INTO commits_records (level, region, ratio, active, score) VALUES (5, 'green', 60.03, 33, 10.02);
