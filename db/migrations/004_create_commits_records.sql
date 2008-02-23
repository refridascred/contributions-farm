-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, ratio, weight) VALUES (91, 55.06, 54.38);
INSERT INTO commits_records (rank, ratio, weight) VALUES (22, 68.95, 44.28);
INSERT INTO commits_records (rank, ratio, weight) VALUES (14, 75.03, 28.18);
