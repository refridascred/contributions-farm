-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, active, rank, region, weight) VALUES (37, 98, 59, 'edge', 20.91);
INSERT INTO commits_records (count, active, rank, region, weight) VALUES (51, 97, 4, 'strict', 56.37);
INSERT INTO commits_records (count, active, rank, region, weight) VALUES (56, 66, 36, 'staging', 12.3);
