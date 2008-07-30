-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, weight, rank) VALUES (33.35, 20.58, 27);
INSERT INTO commits_records (ratio, weight, rank) VALUES (44.78, 43.91, 66);
INSERT INTO commits_records (ratio, weight, rank) VALUES (9.32, 25.9, 36);
