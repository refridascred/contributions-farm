-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, ratio) VALUES (1.05, 34.62, 60.9);
INSERT INTO commits_records (weight, score, ratio) VALUES (87.54, 75.65, 61.65);
