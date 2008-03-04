-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, level, state, owner) VALUES (34, 14, 'strict', 'blue');
INSERT INTO commits_records (active, level, state, owner) VALUES (87, 51, 'fallback', 'latest');
INSERT INTO commits_records (active, level, state, owner) VALUES (23, 56, 'stable', 'local');
