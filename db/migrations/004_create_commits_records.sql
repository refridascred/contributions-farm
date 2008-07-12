-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, ratio, level) VALUES (83, 89.31, 46);
INSERT INTO commits_records (rank, ratio, level) VALUES (3, 16.85, 88);
INSERT INTO commits_records (rank, ratio, level) VALUES (29, 4.89, 55);
