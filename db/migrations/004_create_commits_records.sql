-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, count, state, level) VALUES (93, 47, 'standard', 58);
INSERT INTO commits_records (active, count, state, level) VALUES (52, 33, 'open', 37);
INSERT INTO commits_records (active, count, state, level) VALUES (0, 95, 'latest', 68);
