-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, rank, ratio) VALUES (81, 95, 74.72);
INSERT INTO commits_records (level, rank, ratio) VALUES (24, 28, 94.75);
INSERT INTO commits_records (level, rank, ratio) VALUES (12, 81, 65.08);
