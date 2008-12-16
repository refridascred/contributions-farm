-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, label, weight) VALUES (20.44, 'stable', 2.8);
INSERT INTO commits_records (ratio, label, weight) VALUES (97.87, 'fallback', 23.45);
INSERT INTO commits_records (ratio, label, weight) VALUES (59.89, 'staging', 14.26);
