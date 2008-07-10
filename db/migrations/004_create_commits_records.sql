-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, weight, rank, active) VALUES ('strict', 60.01, 15, 93);
INSERT INTO commits_records (label, weight, rank, active) VALUES ('eu-west', 6.28, 20, 64);
INSERT INTO commits_records (label, weight, rank, active) VALUES ('legacy', 53.54, 57, 55);
