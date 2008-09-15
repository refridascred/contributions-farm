-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, count, weight, level, score) VALUES (75, 93, 94.33, 53, 94.57);
INSERT INTO commits_records (rank, count, weight, level, score) VALUES (92, 92, 62.04, 21, 50.5);
INSERT INTO commits_records (rank, count, weight, level, score) VALUES (18, 85, 27.35, 87, 40.47);
