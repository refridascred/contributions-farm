-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, level, label, state) VALUES (16, 11, 'latest', 'stable');
INSERT INTO commits_records (count, level, label, state) VALUES (10, 6, 'legacy', 'legacy');
INSERT INTO commits_records (count, level, label, state) VALUES (22, 50, 'green', 'cached');
