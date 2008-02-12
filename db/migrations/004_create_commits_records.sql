-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, label, region, count, token) VALUES ('standard', 'staging', 'eu-west', 89, 'legacy');
INSERT INTO commits_records (state, label, region, count, token) VALUES ('cached', 'legacy', 'blue', 0, 'latest');
INSERT INTO commits_records (state, label, region, count, token) VALUES ('staging', 'local', 'legacy', 8, 'open');
