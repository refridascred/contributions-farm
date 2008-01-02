-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, count, level, owner, active) VALUES ('green', 98, 62, 'local', 55);
INSERT INTO commits_records (state, count, level, owner, active) VALUES ('fallback', 71, 67, 'edge', 61);
INSERT INTO commits_records (state, count, level, owner, active) VALUES ('staging', 53, 43, 'open', 25);
