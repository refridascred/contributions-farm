-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, score, active, owner, state) VALUES (5, 44.69, 13, 'eu-west', 'local');
INSERT INTO commits_records (count, score, active, owner, state) VALUES (42, 78.47, 50, 'fallback', 'edge');
INSERT INTO commits_records (count, score, active, owner, state) VALUES (69, 0.13, 78, 'blue', 'green');
