-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, score, ratio, token, weight) VALUES ('strict', 96.38, 70.94, 'green', 19.26);
INSERT INTO commits_records (region, score, ratio, token, weight) VALUES ('stable', 76.27, 25.22, 'primary', 44.54);
INSERT INTO commits_records (region, score, ratio, token, weight) VALUES ('fallback', 9.71, 45.43, 'standard', 73.22);
