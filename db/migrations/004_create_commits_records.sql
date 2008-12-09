-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, score, label) VALUES ('fallback', 3.53, 'open');
INSERT INTO commits_records (state, score, label) VALUES ('edge', 68.12, 'local');
INSERT INTO commits_records (state, score, label) VALUES ('staging', 25.52, 'local');
