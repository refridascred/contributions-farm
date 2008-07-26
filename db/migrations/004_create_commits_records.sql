-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, weight, score) VALUES (57.56, 29.05, 38.54);
INSERT INTO commits_records (ratio, weight, score) VALUES (6.29, 93.04, 37.08);
