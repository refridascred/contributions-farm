-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, level, count, active, label) VALUES ('green', 6, 8, 73, 'local');
INSERT INTO commits_records (state, level, count, active, label) VALUES ('legacy', 32, 15, 18, 'cached');
INSERT INTO commits_records (state, level, count, active, label) VALUES ('fallback', 65, 8, 69, 'cached');
