-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, region, label, level) VALUES (54.07, 27.86, 'cached', 'edge', 67);
INSERT INTO commits_records (weight, score, region, label, level) VALUES (12.19, 88.46, 'green', 'edge', 81);
INSERT INTO commits_records (weight, score, region, label, level) VALUES (48.05, 25.87, 'standard', 'blue', 47);
