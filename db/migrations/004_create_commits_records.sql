-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, token, count, state, active) VALUES (71.99, 'legacy', 58, 'legacy', 51);
INSERT INTO commits_records (score, token, count, state, active) VALUES (34.3, 'strict', 56, 'standard', 13);
INSERT INTO commits_records (score, token, count, state, active) VALUES (53.04, 'eu-west', 53, 'fallback', 45);
