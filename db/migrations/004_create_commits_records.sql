-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, ratio, count, rank, weight) VALUES (91, 93.39, 50, 48, 51.73);
INSERT INTO commits_records (active, ratio, count, rank, weight) VALUES (62, 94.29, 12, 20, 90.07);
INSERT INTO commits_records (active, ratio, count, rank, weight) VALUES (19, 84.22, 30, 32, 45.19);
