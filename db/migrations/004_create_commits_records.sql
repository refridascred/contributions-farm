-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, state, token, label, ratio) VALUES (60, 'standard', 'green', 'fallback', 93.22);
INSERT INTO commits_records (active, state, token, label, ratio) VALUES (14, 'blue', 'edge', 'legacy', 32.73);
INSERT INTO commits_records (active, state, token, label, ratio) VALUES (92, 'edge', 'local', 'eu-west', 48.07);
