-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, ratio, state, label) VALUES (78, 25.31, 'fallback', 'stable');
INSERT INTO commits_records (active, ratio, state, label) VALUES (35, 40.11, 'open', 'green');
