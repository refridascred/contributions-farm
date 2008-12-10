-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, ratio, score, weight) VALUES (4, 6.08, 24.77, 36.04);
INSERT INTO commits_records (level, ratio, score, weight) VALUES (58, 11.98, 76.09, 20.13);
INSERT INTO commits_records (level, ratio, score, weight) VALUES (2, 25.88, 63.84, 29.36);
