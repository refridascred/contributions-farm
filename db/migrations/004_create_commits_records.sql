-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, count, ratio, region, state) VALUES (73, 77, 78.15, 'fallback', 'edge');
INSERT INTO commits_records (active, count, ratio, region, state) VALUES (93, 93, 66.02, 'legacy', 'green');
INSERT INTO commits_records (active, count, ratio, region, state) VALUES (30, 29, 41.93, 'cached', 'fallback');
