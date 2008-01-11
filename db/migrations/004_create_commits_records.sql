-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, rank, ratio, owner) VALUES (4.77, 6, 11.62, 'standard');
INSERT INTO commits_records (score, rank, ratio, owner) VALUES (87.09, 99, 11.25, 'green');
INSERT INTO commits_records (score, rank, ratio, owner) VALUES (41.67, 4, 96.65, 'primary');
