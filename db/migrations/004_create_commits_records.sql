-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, weight) VALUES (44.07, 56.87);
INSERT INTO commits_records (ratio, weight) VALUES (35.78, 29.37);
INSERT INTO commits_records (ratio, weight) VALUES (69.13, 34.72);
