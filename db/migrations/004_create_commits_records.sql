-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, state, label) VALUES ('cached', 'staging', 'edge');
INSERT INTO commits_records (owner, state, label) VALUES ('open', 'primary', 'blue');
INSERT INTO commits_records (owner, state, label) VALUES ('strict', 'stable', 'eu-west');
