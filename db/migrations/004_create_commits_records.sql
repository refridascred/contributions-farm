-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, weight, level, score) VALUES (65.39, 36.39, 48, 41.29);
INSERT INTO commits_records (ratio, weight, level, score) VALUES (88.42, 26.15, 2, 33.26);
