-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, owner, label, score, state) VALUES (63, 'local', 'staging', 14.72, 'legacy');
INSERT INTO commits_records (active, owner, label, score, state) VALUES (56, 'latest', 'legacy', 73.12, 'green');
INSERT INTO commits_records (active, owner, label, score, state) VALUES (86, 'latest', 'edge', 36.79, 'green');
