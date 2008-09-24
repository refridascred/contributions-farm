-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, label, weight) VALUES (38, 'staging', 70.44);
INSERT INTO commits_records (rank, label, weight) VALUES (5, 'blue', 98.31);
INSERT INTO commits_records (rank, label, weight) VALUES (37, 'green', 62.83);
