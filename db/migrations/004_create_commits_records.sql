-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, state, score, active, rank) VALUES (19, 'open', 84.87, 8, 97);
INSERT INTO commits_records (level, state, score, active, rank) VALUES (85, 'stable', 35.2, 56, 33);
INSERT INTO commits_records (level, state, score, active, rank) VALUES (74, 'cached', 64.75, 86, 55);
