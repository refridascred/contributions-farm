-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, active, token, weight, score) VALUES (47.16, 72, 'cached', 55.84, 61.39);
INSERT INTO commits_records (ratio, active, token, weight, score) VALUES (97.28, 83, 'cached', 82.49, 78.42);
INSERT INTO commits_records (ratio, active, token, weight, score) VALUES (41.26, 33, 'cached', 45.88, 42.07);
