-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, weight, owner, count) VALUES (66, 13, 22.94, 'staging', 98);
INSERT INTO commits_records (rank, level, weight, owner, count) VALUES (94, 87, 3.51, 'blue', 40);
