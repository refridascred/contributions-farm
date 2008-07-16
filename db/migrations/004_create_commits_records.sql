-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, count, weight) VALUES (87.96, 59, 73.32);
INSERT INTO commits_records (score, count, weight) VALUES (46.29, 68, 60.41);
INSERT INTO commits_records (score, count, weight) VALUES (8.69, 41, 57.84);
