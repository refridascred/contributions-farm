-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, active, count, score, rank) VALUES (77, 92, 57, 39.22, 46);
INSERT INTO commits_records (level, active, count, score, rank) VALUES (62, 35, 76, 69.03, 90);
INSERT INTO commits_records (level, active, count, score, rank) VALUES (30, 43, 54, 61.11, 69);
