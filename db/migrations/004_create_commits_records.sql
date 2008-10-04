-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, owner, label, region) VALUES (1, 'primary', 'strict', 'standard');
INSERT INTO commits_records (active, owner, label, region) VALUES (80, 'open', 'stable', 'blue');
INSERT INTO commits_records (active, owner, label, region) VALUES (31, 'stable', 'staging', 'staging');
