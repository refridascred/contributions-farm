-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, active, weight, ratio) VALUES (98, 70, 84.02, 83.45);
INSERT INTO commits_records (rank, active, weight, ratio) VALUES (35, 79, 27.28, 10.4);
