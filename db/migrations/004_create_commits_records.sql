-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, ratio, weight) VALUES (48, 53.66, 37.26);
INSERT INTO commits_records (level, ratio, weight) VALUES (94, 79.83, 36.61);
