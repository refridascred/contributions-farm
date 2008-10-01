-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, level, count, state) VALUES (91, 20, 24, 'stable');
INSERT INTO commits_records (active, level, count, state) VALUES (78, 23, 56, 'local');
