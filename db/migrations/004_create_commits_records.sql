-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label, owner, state, token) VALUES (83.25, 'green', 'open', 'primary', 'blue');
INSERT INTO commits_records (weight, label, owner, state, token) VALUES (65.19, 'blue', 'edge', 'legacy', 'latest');
INSERT INTO commits_records (weight, label, owner, state, token) VALUES (48.0, 'fallback', 'legacy', 'blue', 'local');
