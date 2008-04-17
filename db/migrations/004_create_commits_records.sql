-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, level, count, weight) VALUES (43.45, 1, 81, 41.91);
INSERT INTO commits_records (score, level, count, weight) VALUES (59.67, 78, 45, 53.59);
