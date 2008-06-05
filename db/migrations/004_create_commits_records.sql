-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, score, weight) VALUES (89, 41.25, 8.13);
INSERT INTO commits_records (count, score, weight) VALUES (39, 14.0, 71.84);
INSERT INTO commits_records (count, score, weight) VALUES (41, 62.56, 39.98);
