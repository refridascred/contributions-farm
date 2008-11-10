-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, level, rank, weight, score) VALUES (66, 48, 74, 90.52, 59.95);
INSERT INTO commits_records (active, level, rank, weight, score) VALUES (36, 58, 8, 22.68, 54.62);
INSERT INTO commits_records (active, level, rank, weight, score) VALUES (33, 51, 60, 38.38, 89.06);
