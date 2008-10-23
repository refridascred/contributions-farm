-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, weight, state, token) VALUES ('legacy', 96.56, 'edge', 'primary');
INSERT INTO commits_records (label, weight, state, token) VALUES ('staging', 24.17, 'legacy', 'stable');
INSERT INTO commits_records (label, weight, state, token) VALUES ('local', 1.38, 'open', 'strict');
