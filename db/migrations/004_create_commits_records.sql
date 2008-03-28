-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, state, count, owner, level) VALUES (45, 'fallback', 96, 'local', 50);
INSERT INTO commits_records (rank, state, count, owner, level) VALUES (68, 'cached', 95, 'staging', 60);
