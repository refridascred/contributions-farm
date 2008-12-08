-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, ratio, label) VALUES ('staging', 51, 9.24, 'primary');
INSERT INTO commits_records (region, rank, ratio, label) VALUES ('edge', 83, 21.62, 'fallback');
INSERT INTO commits_records (region, rank, ratio, label) VALUES ('staging', 86, 54.14, 'local');
