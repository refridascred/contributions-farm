-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, score, level, ratio) VALUES (35.38, 72.33, 63, 8.11);
INSERT INTO commits_records (weight, score, level, ratio) VALUES (97.51, 53.33, 47, 70.82);
INSERT INTO commits_records (weight, score, level, ratio) VALUES (6.18, 5.58, 5, 59.36);
