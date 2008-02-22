-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token, region, label) VALUES ('staging', 'stable', 'cached', 'stable');
INSERT INTO commits_records (state, token, region, label) VALUES ('fallback', 'latest', 'cached', 'local');
