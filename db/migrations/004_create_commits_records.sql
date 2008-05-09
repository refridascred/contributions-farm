-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, rank, region, active, weight) VALUES (70, 83, 'strict', 52, 41.02);
INSERT INTO commits_records (count, rank, region, active, weight) VALUES (89, 50, 'legacy', 13, 51.12);
INSERT INTO commits_records (count, rank, region, active, weight) VALUES (51, 27, 'eu-west', 19, 88.89);
