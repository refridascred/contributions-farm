-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, active, level, ratio) VALUES ('edge', 58, 19, 41.72);
INSERT INTO commits_records (state, active, level, ratio) VALUES ('stable', 33, 1, 48.63);
INSERT INTO commits_records (state, active, level, ratio) VALUES ('cached', 31, 78, 96.13);
