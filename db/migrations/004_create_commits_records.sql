-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, weight, rank, level, region) VALUES (7.89, 93.63, 92, 50, 'strict');
INSERT INTO commits_records (score, weight, rank, level, region) VALUES (19.01, 26.38, 91, 95, 'strict');
