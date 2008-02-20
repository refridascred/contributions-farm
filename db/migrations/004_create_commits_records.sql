-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, weight, ratio, label, region) VALUES (30.96, 45.57, 16.15, 'edge', 'standard');
INSERT INTO commits_records (score, weight, ratio, label, region) VALUES (25.19, 95.3, 17.49, 'fallback', 'cached');
INSERT INTO commits_records (score, weight, ratio, label, region) VALUES (56.36, 72.35, 93.54, 'staging', 'standard');
