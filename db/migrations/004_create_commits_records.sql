-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, state, owner) VALUES (70.48, 'edge', 'primary');
INSERT INTO commits_records (score, state, owner) VALUES (45.88, 'local', 'edge');
INSERT INTO commits_records (score, state, owner) VALUES (98.18, 'eu-west', 'blue');
