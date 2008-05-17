-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, label, score, owner, state) VALUES (19, 'stable', 79.32, 'open', 'stable');
INSERT INTO commits_records (active, label, score, owner, state) VALUES (75, 'local', 40.58, 'eu-west', 'edge');
INSERT INTO commits_records (active, label, score, owner, state) VALUES (33, 'eu-west', 97.99, 'edge', 'blue');
