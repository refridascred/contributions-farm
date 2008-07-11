-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, rank, token, weight, owner) VALUES (94.26, 37, 'green', 4.73, 'stable');
INSERT INTO commits_records (score, rank, token, weight, owner) VALUES (12.71, 65, 'blue', 57.09, 'strict');
INSERT INTO commits_records (score, rank, token, weight, owner) VALUES (41.71, 88, 'edge', 96.27, 'primary');
