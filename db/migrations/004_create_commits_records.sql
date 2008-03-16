-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label, region) VALUES (87.28, 'cached', 'fallback');
INSERT INTO commits_records (weight, label, region) VALUES (64.53, 'fallback', 'fallback');
INSERT INTO commits_records (weight, label, region) VALUES (49.51, 'blue', 'strict');
