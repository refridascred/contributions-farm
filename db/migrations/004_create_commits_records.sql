-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, rank, region, active, count) VALUES ('local', 81, 'fallback', 12, 52);
INSERT INTO commits_records (label, rank, region, active, count) VALUES ('open', 31, 'green', 60, 52);
INSERT INTO commits_records (label, rank, region, active, count) VALUES ('legacy', 58, 'staging', 45, 38);
