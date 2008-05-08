-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, level, count, score, rank) VALUES (7.41, 18, 62, 96.9, 10);
INSERT INTO commits_records (ratio, level, count, score, rank) VALUES (15.14, 95, 71, 55.77, 53);
INSERT INTO commits_records (ratio, level, count, score, rank) VALUES (42.7, 8, 66, 32.16, 17);
