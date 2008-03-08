-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, score, count, owner, ratio) VALUES (29, 20.87, 66, 'stable', 1.88);
INSERT INTO commits_records (rank, score, count, owner, ratio) VALUES (51, 93.71, 97, 'legacy', 66.73);
INSERT INTO commits_records (rank, score, count, owner, ratio) VALUES (89, 14.95, 23, 'cached', 43.03);
