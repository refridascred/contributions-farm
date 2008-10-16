-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, owner, weight, level, rank) VALUES (39.41, 'green', 64.79, 28, 21);
INSERT INTO commits_records (score, owner, weight, level, rank) VALUES (57.26, 'stable', 5.4, 31, 79);
INSERT INTO commits_records (score, owner, weight, level, rank) VALUES (63.59, 'stable', 18.69, 92, 68);
