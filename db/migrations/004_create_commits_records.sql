-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, owner, active, state, score) VALUES ('local', 'fallback', 90, 'staging', 46.08);
INSERT INTO commits_records (label, owner, active, state, score) VALUES ('cached', 'cached', 16, 'cached', 43.87);
