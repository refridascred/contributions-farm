-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, score, owner) VALUES ('blue', 'edge', 64.87, 'eu-west');
INSERT INTO commits_records (label, state, score, owner) VALUES ('legacy', 'stable', 1.21, 'cached');
