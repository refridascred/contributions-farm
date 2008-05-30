-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, level, weight) VALUES (46.67, 76, 32.41);
INSERT INTO commits_records (ratio, level, weight) VALUES (70.7, 38, 18.16);
INSERT INTO commits_records (ratio, level, weight) VALUES (88.93, 64, 18.11);
