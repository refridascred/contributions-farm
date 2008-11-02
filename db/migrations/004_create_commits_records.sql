-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, weight, state, score, active) VALUES ('edge', 70.87, 'legacy', 44.04, 38);
INSERT INTO commits_records (owner, weight, state, score, active) VALUES ('standard', 60.52, 'eu-west', 94.92, 60);
