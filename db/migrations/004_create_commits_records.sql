-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, ratio) VALUES (7, 77, 16.17);
INSERT INTO commits_records (rank, level, ratio) VALUES (65, 2, 70.06);
INSERT INTO commits_records (rank, level, ratio) VALUES (54, 74, 61.2);
