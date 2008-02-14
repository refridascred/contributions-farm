-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, owner, active, label) VALUES ('open', 'open', 28, 'primary');
INSERT INTO commits_records (region, owner, active, label) VALUES ('staging', 'stable', 59, 'stable');
INSERT INTO commits_records (region, owner, active, label) VALUES ('edge', 'latest', 25, 'fallback');
