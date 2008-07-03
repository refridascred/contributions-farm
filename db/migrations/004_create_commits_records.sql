-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, score, weight, label, rank) VALUES (79.61, 96.99, 84.25, 'cached', 1);
INSERT INTO commits_records (ratio, score, weight, label, rank) VALUES (43.52, 11.04, 91.8, 'standard', 56);
