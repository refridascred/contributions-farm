-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, label, region, owner, ratio) VALUES (8, 'green', 'eu-west', 'fallback', 38.97);
INSERT INTO commits_records (active, label, region, owner, ratio) VALUES (40, 'cached', 'standard', 'edge', 60.46);
