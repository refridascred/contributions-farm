-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, owner, state, token, weight) VALUES ('staging', 'strict', 'stable', 'fallback', 2.45);
INSERT INTO commits_records (label, owner, state, token, weight) VALUES ('primary', 'stable', 'edge', 'local', 31.77);
