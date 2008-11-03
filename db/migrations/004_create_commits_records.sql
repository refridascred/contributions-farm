-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, weight, region, ratio, token) VALUES ('local', 40.33, 'stable', 24.72, 'stable');
INSERT INTO commits_records (label, weight, region, ratio, token) VALUES ('fallback', 19.95, 'strict', 68.58, 'open');
