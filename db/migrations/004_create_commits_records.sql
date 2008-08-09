-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, active, region, rank, weight) VALUES (96, 71, 'staging', 19, 9.89);
INSERT INTO commits_records (count, active, region, rank, weight) VALUES (15, 49, 'open', 94, 40.55);
INSERT INTO commits_records (count, active, region, rank, weight) VALUES (25, 5, 'staging', 76, 66.75);
