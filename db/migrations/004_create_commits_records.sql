-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, weight, ratio) VALUES (99, 37.19, 4.27);
INSERT INTO commits_records (rank, weight, ratio) VALUES (46, 45.26, 23.48);
