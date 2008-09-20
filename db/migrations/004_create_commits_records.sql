-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, weight, ratio, token) VALUES (71, 15.35, 81.07, 'local');
INSERT INTO commits_records (rank, weight, ratio, token) VALUES (90, 32.56, 57.32, 'latest');
INSERT INTO commits_records (rank, weight, ratio, token) VALUES (99, 9.43, 8.97, 'standard');
