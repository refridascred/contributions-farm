-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, active, level, ratio, state) VALUES (2.54, 70, 22, 8.45, 'strict');
INSERT INTO commits_records (weight, active, level, ratio, state) VALUES (9.24, 38, 20, 68.64, 'latest');
