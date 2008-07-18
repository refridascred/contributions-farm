-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, owner, state, active, region) VALUES (50, 'strict', 'blue', 75, 'legacy');
INSERT INTO commits_records (level, owner, state, active, region) VALUES (12, 'stable', 'green', 84, 'blue');
