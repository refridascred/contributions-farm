-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, count, rank, ratio, active) VALUES (34.27, 83, 45, 8.66, 98);
INSERT INTO commits_records (weight, count, rank, ratio, active) VALUES (44.75, 97, 60, 67.67, 58);
INSERT INTO commits_records (weight, count, rank, ratio, active) VALUES (29.55, 91, 11, 38.21, 52);
