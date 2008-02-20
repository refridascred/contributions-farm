-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, level, state) VALUES (85, 14, 'stable');
INSERT INTO commits_records (count, level, state) VALUES (30, 4, 'standard');
INSERT INTO commits_records (count, level, state) VALUES (73, 56, 'open');
