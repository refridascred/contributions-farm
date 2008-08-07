-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, count, weight, active) VALUES (49.01, 49, 41.61, 79);
INSERT INTO commits_records (ratio, count, weight, active) VALUES (67.52, 52, 58.58, 72);
INSERT INTO commits_records (ratio, count, weight, active) VALUES (84.82, 4, 65.36, 27);
