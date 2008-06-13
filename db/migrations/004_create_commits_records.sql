-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, state, owner, active) VALUES ('primary', 'blue', 'edge', 54);
INSERT INTO commits_records (region, state, owner, active) VALUES ('staging', 'strict', 'staging', 68);
INSERT INTO commits_records (region, state, owner, active) VALUES ('local', 'blue', 'stable', 55);
