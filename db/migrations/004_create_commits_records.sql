-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, active, rank, region) VALUES ('stable', 63, 23, 'legacy');
INSERT INTO commits_records (label, active, rank, region) VALUES ('local', 48, 75, 'standard');
INSERT INTO commits_records (label, active, rank, region) VALUES ('legacy', 68, 67, 'latest');
