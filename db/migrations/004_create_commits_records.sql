-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, token, rank, state, active) VALUES ('local', 'staging', 68, 'standard', 58);
INSERT INTO commits_records (label, token, rank, state, active) VALUES ('cached', 'cached', 76, 'edge', 65);
INSERT INTO commits_records (label, token, rank, state, active) VALUES ('legacy', 'local', 74, 'blue', 33);
