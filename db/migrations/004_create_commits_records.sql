-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, owner, state, label) VALUES (65.24, 'fallback', 'edge', 'primary');
INSERT INTO commits_records (score, owner, state, label) VALUES (61.2, 'fallback', 'edge', 'latest');
INSERT INTO commits_records (score, owner, state, label) VALUES (59.68, 'edge', 'legacy', 'stable');
