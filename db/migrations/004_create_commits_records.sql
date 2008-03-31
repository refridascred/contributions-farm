-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, active, rank) VALUES (24.97, 42, 54);
INSERT INTO commits_records (weight, active, rank) VALUES (35.82, 51, 4);
INSERT INTO commits_records (weight, active, rank) VALUES (51.32, 31, 20);
