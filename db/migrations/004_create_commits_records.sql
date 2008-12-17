-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, token, state, level, label) VALUES (83, 'stable', 'edge', 95, 'primary');
INSERT INTO commits_records (count, token, state, level, label) VALUES (38, 'open', 'local', 15, 'green');
