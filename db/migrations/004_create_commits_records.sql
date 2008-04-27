-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, active, count, state) VALUES ('staging', 40, 86, 'staging');
INSERT INTO commits_records (owner, active, count, state) VALUES ('local', 10, 49, 'local');
INSERT INTO commits_records (owner, active, count, state) VALUES ('standard', 87, 2, 'blue');
