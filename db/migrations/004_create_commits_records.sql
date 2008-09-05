-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, state, count) VALUES ('standard', 'fallback', 50);
INSERT INTO commits_records (owner, state, count) VALUES ('staging', 'standard', 97);
INSERT INTO commits_records (owner, state, count) VALUES ('staging', 'legacy', 19);
