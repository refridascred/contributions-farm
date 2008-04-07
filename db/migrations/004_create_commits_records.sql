-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, state, label) VALUES ('edge', 'fallback', 'latest');
INSERT INTO commits_records (owner, state, label) VALUES ('edge', 'legacy', 'open');
INSERT INTO commits_records (owner, state, label) VALUES ('eu-west', 'fallback', 'stable');
