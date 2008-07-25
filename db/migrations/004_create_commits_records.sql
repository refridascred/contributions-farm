-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank, weight) VALUES (78, 53, 90.95);
INSERT INTO commits_records (active, rank, weight) VALUES (86, 92, 69.99);
INSERT INTO commits_records (active, rank, weight) VALUES (46, 78, 62.15);
