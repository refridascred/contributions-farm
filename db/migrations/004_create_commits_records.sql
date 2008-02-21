-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, state, region, token) VALUES ('eu-west', 'green', 'latest', 'eu-west');
INSERT INTO commits_records (label, state, region, token) VALUES ('green', 'cached', 'staging', 'blue');
