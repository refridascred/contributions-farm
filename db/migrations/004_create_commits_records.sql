-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, state, ratio, rank) VALUES (45, 'green', 42.85, 27);
INSERT INTO commits_records (level, state, ratio, rank) VALUES (44, 'green', 9.78, 84);
