-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, token, label) VALUES ('blue', 'green', 'primary');
INSERT INTO commits_records (state, token, label) VALUES ('latest', 'green', 'latest');
INSERT INTO commits_records (state, token, label) VALUES ('stable', 'green', 'eu-west');
