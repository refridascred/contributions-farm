-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, token, state, label) VALUES ('primary', 'fallback', 'stable', 'standard');
INSERT INTO commits_records (owner, token, state, label) VALUES ('primary', 'standard', 'blue', 'legacy');
INSERT INTO commits_records (owner, token, state, label) VALUES ('staging', 'staging', 'legacy', 'standard');
