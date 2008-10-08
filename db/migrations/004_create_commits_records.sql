-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, level, state, active, token) VALUES ('latest', 33, 'edge', 20, 'staging');
INSERT INTO commits_records (owner, level, state, active, token) VALUES ('primary', 81, 'cached', 48, 'legacy');
INSERT INTO commits_records (owner, level, state, active, token) VALUES ('staging', 71, 'primary', 16, 'stable');
