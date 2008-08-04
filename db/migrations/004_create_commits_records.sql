-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, rank, owner, level) VALUES ('stable', 64, 'local', 30);
INSERT INTO commits_records (state, rank, owner, level) VALUES ('edge', 48, 'fallback', 53);
