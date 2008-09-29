-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, score, level, count) VALUES ('cached', 8.79, 57, 30);
INSERT INTO commits_records (region, score, level, count) VALUES ('edge', 10.96, 57, 55);
