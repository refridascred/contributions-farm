-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, level, region, rank) VALUES (69, 39, 'standard', 59);
INSERT INTO commits_records (active, level, region, rank) VALUES (80, 71, 'latest', 25);
INSERT INTO commits_records (active, level, region, rank) VALUES (30, 48, 'standard', 16);
