-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, active, weight) VALUES (23.3, 42, 79.6);
INSERT INTO commits_records (ratio, active, weight) VALUES (96.52, 63, 60.22);
INSERT INTO commits_records (ratio, active, weight) VALUES (94.24, 8, 64.01);
