-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, label, weight, region) VALUES (67, 'primary', 41.17, 'strict');
INSERT INTO commits_records (active, label, weight, region) VALUES (31, 'fallback', 20.71, 'cached');
