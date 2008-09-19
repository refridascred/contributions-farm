-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, label, state) VALUES ('legacy', 'eu-west', 'cached');
INSERT INTO commits_records (token, label, state) VALUES ('green', 'fallback', 'legacy');
