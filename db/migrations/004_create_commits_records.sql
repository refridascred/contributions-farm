-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, weight, rank) VALUES (84.89, 80.77, 38);
INSERT INTO commits_records (ratio, weight, rank) VALUES (5.35, 33.15, 90);
INSERT INTO commits_records (ratio, weight, rank) VALUES (91.85, 74.24, 82);
