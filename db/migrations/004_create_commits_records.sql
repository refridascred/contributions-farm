-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, level, weight, region, active) VALUES (64.27, 43, 11.21, 'stable', 49);
INSERT INTO commits_records (ratio, level, weight, region, active) VALUES (69.16, 86, 82.37, 'green', 43);
INSERT INTO commits_records (ratio, level, weight, region, active) VALUES (38.56, 15, 92.37, 'strict', 61);
