-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, region, owner, state, weight) VALUES (67, 'fallback', 'standard', 'primary', 50.91);
INSERT INTO commits_records (active, region, owner, state, weight) VALUES (8, 'stable', 'latest', 'latest', 96.24);
INSERT INTO commits_records (active, region, owner, state, weight) VALUES (56, 'strict', 'legacy', 'latest', 39.74);
