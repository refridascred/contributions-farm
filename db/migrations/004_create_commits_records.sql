-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, region, state, owner, ratio) VALUES (44, 'fallback', 'cached', 'edge', 69.62);
INSERT INTO commits_records (active, region, state, owner, ratio) VALUES (92, 'legacy', 'standard', 'standard', 10.6);
