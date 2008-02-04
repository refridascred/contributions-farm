-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, weight, count, score) VALUES ('stable', 36.84, 93, 49.67);
INSERT INTO commits_records (token, weight, count, score) VALUES ('fallback', 81.78, 1, 8.34);
INSERT INTO commits_records (token, weight, count, score) VALUES ('strict', 49.42, 51, 37.15);
