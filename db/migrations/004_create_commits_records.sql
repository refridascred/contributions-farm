-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, level, rank, token) VALUES (70.04, 19, 62, 'primary');
INSERT INTO commits_records (ratio, level, rank, token) VALUES (51.98, 34, 30, 'blue');
