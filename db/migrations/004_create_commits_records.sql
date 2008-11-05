-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, level, rank, region) VALUES (84.51, 86, 84, 'strict');
INSERT INTO commits_records (ratio, level, rank, region) VALUES (80.91, 18, 67, 'primary');
INSERT INTO commits_records (ratio, level, rank, region) VALUES (31.75, 42, 95, 'local');
