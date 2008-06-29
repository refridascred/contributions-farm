-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, count, score) VALUES (99, 31, 50.55);
INSERT INTO commits_records (level, count, score) VALUES (72, 93, 20.0);
INSERT INTO commits_records (level, count, score) VALUES (76, 23, 62.81);
