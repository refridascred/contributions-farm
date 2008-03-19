-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, state, count, label) VALUES ('green', 'blue', 19, 'strict');
INSERT INTO commits_records (token, state, count, label) VALUES ('blue', 'cached', 23, 'eu-west');
