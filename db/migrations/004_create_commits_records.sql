-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, score, ratio, rank, count) VALUES (57, 67.77, 56.65, 62, 76);
INSERT INTO commits_records (level, score, ratio, rank, count) VALUES (40, 90.6, 84.92, 83, 92);
INSERT INTO commits_records (level, score, ratio, rank, count) VALUES (80, 91.85, 78.85, 97, 3);
