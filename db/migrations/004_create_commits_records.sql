-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, region, label, state) VALUES ('staging', 'local', 'blue', 'open');
INSERT INTO commits_records (owner, region, label, state) VALUES ('stable', 'stable', 'strict', 'strict');
INSERT INTO commits_records (owner, region, label, state) VALUES ('primary', 'fallback', 'local', 'edge');
