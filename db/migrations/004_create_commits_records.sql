-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, ratio, weight, state, rank) VALUES (11, 57.3, 78.08, 'cached', 13);
INSERT INTO commits_records (level, ratio, weight, state, rank) VALUES (30, 15.55, 23.84, 'edge', 97);
