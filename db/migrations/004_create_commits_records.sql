-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, owner, state) VALUES (23, 'stable', 'latest');
INSERT INTO commits_records (level, owner, state) VALUES (60, 'blue', 'edge');
INSERT INTO commits_records (level, owner, state) VALUES (80, 'stable', 'standard');
