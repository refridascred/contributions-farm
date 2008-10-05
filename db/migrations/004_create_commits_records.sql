-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, score, level, ratio, weight) VALUES (78, 96.4, 12, 97.74, 30.01);
INSERT INTO commits_records (count, score, level, ratio, weight) VALUES (8, 60.66, 66, 43.0, 14.33);
