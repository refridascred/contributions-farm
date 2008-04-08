-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, region, owner, state, weight) VALUES (95.82, 'blue', 'green', 'legacy', 41.22);
INSERT INTO commits_records (ratio, region, owner, state, weight) VALUES (80.21, 'legacy', 'stable', 'legacy', 79.36);
