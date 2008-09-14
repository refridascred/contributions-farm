-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, ratio, weight) VALUES (57, 23.07, 22.15);
INSERT INTO commits_records (level, ratio, weight) VALUES (34, 8.57, 91.5);
INSERT INTO commits_records (level, ratio, weight) VALUES (39, 69.74, 95.81);
