-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, label, region, owner) VALUES ('edge', 'stable', 'standard', 'local');
INSERT INTO commits_records (state, label, region, owner) VALUES ('staging', 'edge', 'edge', 'standard');
INSERT INTO commits_records (state, label, region, owner) VALUES ('primary', 'local', 'fallback', 'green');
