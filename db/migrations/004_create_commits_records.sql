-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, weight, token, region, label) VALUES (30, 61.8, 'edge', 'blue', 'strict');
INSERT INTO commits_records (level, weight, token, region, label) VALUES (52, 80.74, 'blue', 'fallback', 'open');
