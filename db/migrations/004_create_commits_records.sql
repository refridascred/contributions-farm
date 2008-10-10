-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, state, active, label, ratio) VALUES ('fallback', 'edge', 9, 'open', 48.73);
INSERT INTO commits_records (token, state, active, label, ratio) VALUES ('open', 'primary', 79, 'strict', 96.32);
INSERT INTO commits_records (token, state, active, label, ratio) VALUES ('strict', 'legacy', 77, 'legacy', 91.84);
