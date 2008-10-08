-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, count, score) VALUES (69, 67.79, 81, 72.99);
INSERT INTO commits_records (level, ratio, count, score) VALUES (71, 29.93, 70, 21.38);
INSERT INTO commits_records (level, ratio, count, score) VALUES (11, 41.11, 52, 28.97);
