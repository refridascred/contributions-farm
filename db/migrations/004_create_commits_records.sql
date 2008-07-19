-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, count, owner, state, active) VALUES ('local', 35, 'strict', 'legacy', 42);
INSERT INTO commits_records (region, count, owner, state, active) VALUES ('eu-west', 13, 'strict', 'stable', 60);
INSERT INTO commits_records (region, count, owner, state, active) VALUES ('blue', 26, 'legacy', 'open', 48);
