-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, level, ratio, state, rank) VALUES (28, 52, 38.77, 'green', 96);
INSERT INTO commits_records (active, level, ratio, state, rank) VALUES (46, 0, 70.9, 'stable', 55);
