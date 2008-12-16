-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, weight, level, state, owner) VALUES (27.81, 51.74, 86, 'open', 'strict');
INSERT INTO commits_records (score, weight, level, state, owner) VALUES (6.57, 38.75, 27, 'fallback', 'open');
INSERT INTO commits_records (score, weight, level, state, owner) VALUES (29.64, 97.64, 5, 'edge', 'stable');
