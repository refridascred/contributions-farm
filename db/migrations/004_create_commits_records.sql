-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, token, region, ratio) VALUES (13, 'edge', 'edge', 38.06);
INSERT INTO commits_records (rank, token, region, ratio) VALUES (11, 'edge', 'stable', 9.97);
