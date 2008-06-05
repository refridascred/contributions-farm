-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, label, state, ratio, weight) VALUES (5, 'legacy', 'fallback', 18.77, 59.34);
INSERT INTO commits_records (active, label, state, ratio, weight) VALUES (26, 'edge', 'staging', 6.06, 48.7);
INSERT INTO commits_records (active, label, state, ratio, weight) VALUES (26, 'strict', 'staging', 83.96, 32.49);
