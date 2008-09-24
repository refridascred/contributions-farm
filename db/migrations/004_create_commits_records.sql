-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, region, rank, label, active) VALUES (75, 'fallback', 20, 'strict', 71);
INSERT INTO commits_records (level, region, rank, label, active) VALUES (59, 'green', 42, 'edge', 6);
