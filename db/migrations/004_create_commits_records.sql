-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, state, token, label) VALUES (40.51, 'strict', 'latest', 'fallback');
INSERT INTO commits_records (score, state, token, label) VALUES (75.24, 'stable', 'fallback', 'green');
