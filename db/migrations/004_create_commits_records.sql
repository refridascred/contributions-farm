-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region, state, label, active) VALUES (97.78, 'primary', 'fallback', 'legacy', 11);
INSERT INTO commits_records (ratio, region, state, label, active) VALUES (2.14, 'fallback', 'edge', 'cached', 6);
INSERT INTO commits_records (ratio, region, state, label, active) VALUES (48.96, 'cached', 'fallback', 'latest', 49);
