-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, ratio, rank) VALUES ('strict', 11.86, 22);
INSERT INTO commits_records (label, ratio, rank) VALUES ('edge', 39.78, 22);
