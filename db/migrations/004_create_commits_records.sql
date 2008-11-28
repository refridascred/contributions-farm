-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, active) VALUES ('eu-west', 'legacy', 58);
INSERT INTO commits_records (token, state, active) VALUES ('primary', 'standard', 98);
INSERT INTO commits_records (token, state, active) VALUES ('staging', 'cached', 46);
