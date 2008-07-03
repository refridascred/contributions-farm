-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, label, owner) VALUES ('eu-west', 'primary', 'primary');
INSERT INTO commits_records (state, label, owner) VALUES ('blue', 'fallback', 'green');
INSERT INTO commits_records (state, label, owner) VALUES ('strict', 'local', 'local');
