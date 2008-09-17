-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, level, count, rank, active) VALUES (70.68, 68, 58, 49, 99);
INSERT INTO commits_records (weight, level, count, rank, active) VALUES (53.7, 37, 4, 11, 37);
INSERT INTO commits_records (weight, level, count, rank, active) VALUES (2.68, 60, 64, 22, 8);
