-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, rank, region) VALUES (0.32, 36, 'green');
INSERT INTO commits_records (weight, rank, region) VALUES (95.95, 88, 'green');
INSERT INTO commits_records (weight, rank, region) VALUES (38.59, 64, 'green');
