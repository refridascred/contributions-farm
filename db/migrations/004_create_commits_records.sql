-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank, ratio, weight) VALUES (25, 52, 53.18, 39.74);
INSERT INTO commits_records (active, rank, ratio, weight) VALUES (4, 61, 61.63, 84.99);
INSERT INTO commits_records (active, rank, ratio, weight) VALUES (1, 70, 12.7, 55.01);
