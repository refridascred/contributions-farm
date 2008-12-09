-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, weight, label) VALUES (0, 89.82, 'legacy');
INSERT INTO commits_records (rank, weight, label) VALUES (22, 60.55, 'eu-west');
INSERT INTO commits_records (rank, weight, label) VALUES (86, 11.52, 'stable');
