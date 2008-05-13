-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, owner, active, label) VALUES ('latest', 'open', 20, 'primary');
INSERT INTO commits_records (state, owner, active, label) VALUES ('legacy', 'legacy', 46, 'green');
INSERT INTO commits_records (state, owner, active, label) VALUES ('legacy', 'standard', 47, 'local');
