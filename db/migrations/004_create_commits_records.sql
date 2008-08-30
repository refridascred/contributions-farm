-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, state, owner, active) VALUES (31.94, 'cached', 'stable', 43);
INSERT INTO commits_records (score, state, owner, active) VALUES (10.75, 'open', 'fallback', 43);
INSERT INTO commits_records (score, state, owner, active) VALUES (21.98, 'green', 'local', 66);
