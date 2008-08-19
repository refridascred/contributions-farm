-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, region, active, owner) VALUES (85, 'primary', 95, 'eu-west');
INSERT INTO commits_records (rank, region, active, owner) VALUES (9, 'local', 60, 'primary');
INSERT INTO commits_records (rank, region, active, owner) VALUES (68, 'stable', 92, 'local');
