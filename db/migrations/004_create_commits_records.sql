-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, rank, active, count) VALUES (27.76, 14, 60, 61);
INSERT INTO commits_records (weight, rank, active, count) VALUES (57.68, 94, 62, 33);
INSERT INTO commits_records (weight, rank, active, count) VALUES (23.23, 15, 47, 35);
