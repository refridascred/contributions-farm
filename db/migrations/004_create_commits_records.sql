-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, active, owner) VALUES ('eu-west', 18, 'staging');
