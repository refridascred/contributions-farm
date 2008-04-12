-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, token, label) VALUES ('legacy', 'legacy', 'open');
INSERT INTO commits_records (state, token, label) VALUES ('green', 'cached', 'cached');
INSERT INTO commits_records (state, token, label) VALUES ('open', 'edge', 'eu-west');
