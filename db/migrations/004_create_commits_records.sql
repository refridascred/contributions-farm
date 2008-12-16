-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, count, label, owner, active) VALUES ('eu-west', 76, 'edge', 'strict', 15);
INSERT INTO commits_records (region, count, label, owner, active) VALUES ('latest', 62, 'edge', 'fallback', 32);
