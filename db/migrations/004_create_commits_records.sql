-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, region, owner, ratio, label) VALUES (1, 'strict', 'cached', 7.42, 'edge');
INSERT INTO commits_records (active, region, owner, ratio, label) VALUES (26, 'local', 'standard', 37.77, 'green');
