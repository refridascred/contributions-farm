-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, weight, ratio, label, region) VALUES (31, 21.23, 10.55, 'green', 'legacy');
INSERT INTO commits_records (active, weight, ratio, label, region) VALUES (82, 35.01, 28.94, 'staging', 'open');
INSERT INTO commits_records (active, weight, ratio, label, region) VALUES (45, 64.91, 43.53, 'stable', 'stable');
