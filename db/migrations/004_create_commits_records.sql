-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, weight, level, state, active) VALUES (82.65, 16.17, 34, 'blue', 47);
INSERT INTO commits_records (ratio, weight, level, state, active) VALUES (91.25, 16.44, 58, 'primary', 36);
