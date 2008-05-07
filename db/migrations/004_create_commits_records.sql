-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, owner, ratio, state, count) VALUES (64.6, 'green', 59.21, 'stable', 14);
INSERT INTO commits_records (score, owner, ratio, state, count) VALUES (4.1, 'fallback', 47.86, 'fallback', 14);
INSERT INTO commits_records (score, owner, ratio, state, count) VALUES (2.06, 'eu-west', 59.94, 'legacy', 21);
