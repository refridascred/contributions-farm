-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, state, label, count) VALUES (86, 'stable', 'latest', 37);
INSERT INTO commits_records (level, state, label, count) VALUES (93, 'eu-west', 'legacy', 72);
