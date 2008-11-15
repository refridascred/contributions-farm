-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, active, weight, level) VALUES (52, 72, 52.05, 78);
INSERT INTO commits_records (rank, active, weight, level) VALUES (47, 49, 17.98, 55);
INSERT INTO commits_records (rank, active, weight, level) VALUES (90, 33, 24.04, 88);
