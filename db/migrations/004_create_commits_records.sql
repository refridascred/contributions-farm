-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, owner, active, state) VALUES ('blue', 'local', 94, 'stable');
INSERT INTO commits_records (region, owner, active, state) VALUES ('local', 'local', 60, 'local');
INSERT INTO commits_records (region, owner, active, state) VALUES ('green', 'staging', 42, 'eu-west');
