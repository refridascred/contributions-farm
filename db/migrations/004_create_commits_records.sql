-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, state, active, count) VALUES (93.93, 'fallback', 62, 40);
INSERT INTO commits_records (score, state, active, count) VALUES (30.18, 'primary', 52, 34);
INSERT INTO commits_records (score, state, active, count) VALUES (29.15, 'local', 91, 96);
