-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, owner, state, level, active) VALUES (86.07, 'cached', 'eu-west', 9, 29);
INSERT INTO commits_records (score, owner, state, level, active) VALUES (47.67, 'blue', 'standard', 78, 42);
