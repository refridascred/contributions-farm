-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, owner, state, label) VALUES (7, 'standard', 'blue', 'standard');
INSERT INTO commits_records (count, owner, state, label) VALUES (65, 'staging', 'strict', 'open');
INSERT INTO commits_records (count, owner, state, label) VALUES (55, 'standard', 'open', 'green');
