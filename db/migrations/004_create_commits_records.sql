-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, label, state) VALUES ('edge', 'stable', 'fallback');
INSERT INTO commits_records (token, label, state) VALUES ('standard', 'eu-west', 'local');
INSERT INTO commits_records (token, label, state) VALUES ('fallback', 'primary', 'primary');
