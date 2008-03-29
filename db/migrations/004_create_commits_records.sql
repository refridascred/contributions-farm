-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, active, label, state) VALUES ('primary', 28, 'latest', 'strict');
INSERT INTO commits_records (token, active, label, state) VALUES ('primary', 30, 'blue', 'eu-west');
INSERT INTO commits_records (token, active, label, state) VALUES ('fallback', 70, 'open', 'primary');
