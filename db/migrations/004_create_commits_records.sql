-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, rank, token) VALUES (59.35, 53, 'standard');
INSERT INTO commits_records (weight, rank, token) VALUES (84.52, 42, 'eu-west');
INSERT INTO commits_records (weight, rank, token) VALUES (85.92, 71, 'latest');
