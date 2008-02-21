-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, active, state, owner) VALUES ('edge', 1, 'eu-west', 'green');
INSERT INTO commits_records (label, active, state, owner) VALUES ('cached', 71, 'strict', 'standard');
INSERT INTO commits_records (label, active, state, owner) VALUES ('stable', 77, 'standard', 'strict');
