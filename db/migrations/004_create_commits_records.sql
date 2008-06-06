-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, token, active, count) VALUES ('legacy', 'standard', 'primary', 13, 37);
INSERT INTO commits_records (label, state, token, active, count) VALUES ('eu-west', 'eu-west', 'standard', 19, 77);
