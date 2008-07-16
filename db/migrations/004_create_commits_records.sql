-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, score, label, active, state) VALUES ('strict', 55.24, 'eu-west', 25, 'eu-west');
INSERT INTO commits_records (owner, score, label, active, state) VALUES ('primary', 68.79, 'open', 60, 'edge');
