-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, owner, state, label, level) VALUES (29, 'local', 'legacy', 'eu-west', 34);
INSERT INTO commits_records (rank, owner, state, label, level) VALUES (97, 'fallback', 'blue', 'edge', 3);
