-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, level, token, active) VALUES ('latest', 'fallback', 89, 'strict', 28);
INSERT INTO commits_records (label, state, level, token, active) VALUES ('local', 'cached', 95, 'green', 29);
INSERT INTO commits_records (label, state, level, token, active) VALUES ('eu-west', 'open', 79, 'green', 52);
