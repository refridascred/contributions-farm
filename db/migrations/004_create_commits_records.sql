-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, weight, level, score, ratio) VALUES (88, 85.98, 17, 54.28, 62.32);
INSERT INTO commits_records (count, weight, level, score, ratio) VALUES (77, 56.73, 62, 17.34, 54.95);
