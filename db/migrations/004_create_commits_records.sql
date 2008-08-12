-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, rank, weight, ratio) VALUES (75, 9, 87.27, 39.87);
INSERT INTO commits_records (active, rank, weight, ratio) VALUES (7, 96, 7.68, 75.24);
INSERT INTO commits_records (active, rank, weight, ratio) VALUES (69, 79, 26.41, 36.32);
