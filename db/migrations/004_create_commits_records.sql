-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, level, weight) VALUES (76.77, 72, 61.56);
INSERT INTO commits_records (ratio, level, weight) VALUES (28.66, 24, 52.86);
