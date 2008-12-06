-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, weight, region, score, level) VALUES (22, 60.87, 'staging', 80.37, 71);
INSERT INTO commits_records (active, weight, region, score, level) VALUES (58, 67.05, 'cached', 30.8, 48);
