-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, level, ratio) VALUES (66.52, 99, 81.38);
INSERT INTO commits_records (weight, level, ratio) VALUES (43.13, 0, 22.75);
