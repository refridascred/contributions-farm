-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, region, active, label) VALUES (61, 'legacy', 33, 'standard');
