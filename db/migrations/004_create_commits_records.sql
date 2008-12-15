-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, ratio, rank, token) VALUES (9, 66.5, 98, 'cached');
INSERT INTO commits_records (level, ratio, rank, token) VALUES (97, 30.24, 2, 'cached');
