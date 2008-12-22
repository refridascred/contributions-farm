-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, rank, active, region) VALUES (42, 51, 43, 'edge');
INSERT INTO commits_records (level, rank, active, region) VALUES (73, 32, 39, 'green');
INSERT INTO commits_records (level, rank, active, region) VALUES (18, 50, 67, 'eu-west');
