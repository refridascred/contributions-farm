-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, owner, label, region) VALUES ('standard', 'fallback', 'fallback', 'standard');
INSERT INTO commits_records (state, owner, label, region) VALUES ('green', 'cached', 'local', 'primary');
INSERT INTO commits_records (state, owner, label, region) VALUES ('fallback', 'eu-west', 'eu-west', 'strict');
