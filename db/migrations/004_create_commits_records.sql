-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, ratio, rank, weight, region) VALUES (87, 64.46, 46, 38.93, 'strict');
INSERT INTO commits_records (active, ratio, rank, weight, region) VALUES (70, 19.77, 37, 12.91, 'staging');
INSERT INTO commits_records (active, ratio, rank, weight, region) VALUES (45, 65.48, 92, 85.85, 'edge');
