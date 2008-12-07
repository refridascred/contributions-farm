-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, region, owner) VALUES (74.18, 'standard', 'edge');
INSERT INTO commits_records (weight, region, owner) VALUES (58.23, 'legacy', 'fallback');
INSERT INTO commits_records (weight, region, owner) VALUES (93.17, 'fallback', 'fallback');
