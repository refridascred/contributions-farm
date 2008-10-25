-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, state, count) VALUES (47, 'edge', 78);
INSERT INTO commits_records (level, state, count) VALUES (84, 'green', 97);
INSERT INTO commits_records (level, state, count) VALUES (98, 'cached', 64);
