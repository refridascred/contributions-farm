-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, state, ratio) VALUES (78.45, 'open', 60.88);
INSERT INTO commits_records (score, state, ratio) VALUES (5.75, 'open', 64.35);
INSERT INTO commits_records (score, state, ratio) VALUES (82.11, 'local', 5.24);
