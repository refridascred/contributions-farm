-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label, ratio) VALUES (47.11, 'fallback', 4.89);
INSERT INTO commits_records (weight, label, ratio) VALUES (1.59, 'blue', 54.96);
