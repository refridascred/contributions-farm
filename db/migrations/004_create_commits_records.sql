-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, weight, active, count) VALUES ('cached', 15.6, 54, 11);
INSERT INTO commits_records (region, weight, active, count) VALUES ('standard', 9.34, 56, 75);
INSERT INTO commits_records (region, weight, active, count) VALUES ('blue', 13.79, 93, 81);
