-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, label, weight, token) VALUES (10.65, 'edge', 'stable', 86.4, 'strict');
INSERT INTO commits_records (ratio, state, label, weight, token) VALUES (22.67, 'local', 'legacy', 3.54, 'edge');
