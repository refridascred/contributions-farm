-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, owner, region, active) VALUES ('cached', 'cached', 'fallback', 56);
INSERT INTO commits_records (label, owner, region, active) VALUES ('stable', 'fallback', 'green', 64);
