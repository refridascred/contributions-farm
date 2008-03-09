-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, ratio) VALUES (48, 77, 76.88);
INSERT INTO commits_records (rank, level, ratio) VALUES (44, 53, 71.63);
INSERT INTO commits_records (rank, level, ratio) VALUES (94, 25, 73.49);
