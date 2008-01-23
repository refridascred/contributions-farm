-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, state, active, count) VALUES (5, 'primary', 3, 41);
INSERT INTO commits_records (level, state, active, count) VALUES (1, 'stable', 35, 95);
INSERT INTO commits_records (level, state, active, count) VALUES (17, 'open', 39, 2);
