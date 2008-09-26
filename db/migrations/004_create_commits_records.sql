-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, region, active, state, owner) VALUES ('open', 'strict', 51, 'open', 'edge');
INSERT INTO commits_records (label, region, active, state, owner) VALUES ('eu-west', 'blue', 66, 'eu-west', 'fallback');
INSERT INTO commits_records (label, region, active, state, owner) VALUES ('green', 'fallback', 27, 'staging', 'open');
