-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, active, owner, state) VALUES ('eu-west', 71, 'legacy', 'edge');
INSERT INTO commits_records (label, active, owner, state) VALUES ('blue', 90, 'legacy', 'staging');
INSERT INTO commits_records (label, active, owner, state) VALUES ('staging', 52, 'stable', 'stable');
