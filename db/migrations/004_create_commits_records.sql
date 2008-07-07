-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, ratio, rank, owner) VALUES (71, 65.67, 3.47, 95, 'legacy');
INSERT INTO commits_records (count, score, ratio, rank, owner) VALUES (11, 62.38, 14.26, 55, 'stable');
INSERT INTO commits_records (count, score, ratio, rank, owner) VALUES (45, 39.12, 86.38, 43, 'open');
