-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, count, level, state, score) VALUES (87, 45, 91, 'green', 56.11);
INSERT INTO commits_records (active, count, level, state, score) VALUES (86, 80, 4, 'edge', 14.95);
