-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, region, label, rank) VALUES (18.36, 'green', 'stable', 82);
INSERT INTO commits_records (weight, region, label, rank) VALUES (71.15, 'legacy', 'legacy', 14);
