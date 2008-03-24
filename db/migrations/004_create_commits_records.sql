-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, count, owner, state) VALUES ('standard', 30, 'open', 'open');
INSERT INTO commits_records (label, count, owner, state) VALUES ('open', 86, 'staging', 'edge');
INSERT INTO commits_records (label, count, owner, state) VALUES ('latest', 15, 'strict', 'staging');
