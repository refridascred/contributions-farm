-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, owner, state, active) VALUES (98.58, 'legacy', 'stable', 83);
INSERT INTO commits_records (ratio, owner, state, active) VALUES (63.19, 'eu-west', 'cached', 60);
