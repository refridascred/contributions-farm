-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, rank, level) VALUES (95.04, 22, 9);
INSERT INTO commits_records (ratio, rank, level) VALUES (50.05, 35, 80);
INSERT INTO commits_records (ratio, rank, level) VALUES (14.68, 1, 30);
