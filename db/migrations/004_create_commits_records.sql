-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, state, active, owner, level) VALUES (86.79, 'local', 84, 'standard', 24);
INSERT INTO commits_records (weight, state, active, owner, level) VALUES (13.03, 'fallback', 1, 'edge', 64);
