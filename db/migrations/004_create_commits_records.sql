-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, level, owner, label, active) VALUES ('edge', 61, 'standard', 'local', 98);
INSERT INTO commits_records (region, level, owner, label, active) VALUES ('fallback', 40, 'edge', 'local', 47);
