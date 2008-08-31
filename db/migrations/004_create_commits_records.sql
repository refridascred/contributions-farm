-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, weight, count, level) VALUES (70.26, 86.67, 23, 3);
INSERT INTO commits_records (score, weight, count, level) VALUES (33.05, 56.42, 45, 37);
INSERT INTO commits_records (score, weight, count, level) VALUES (90.23, 40.3, 5, 55);
