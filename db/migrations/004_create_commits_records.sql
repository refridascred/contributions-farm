-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, ratio) VALUES ('strict', 15, 67.46);
INSERT INTO commits_records (region, rank, ratio) VALUES ('open', 46, 85.37);
