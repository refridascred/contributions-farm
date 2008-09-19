-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, weight, state, count, rank) VALUES (75, 34.44, 'edge', 39, 45);
INSERT INTO commits_records (active, weight, state, count, rank) VALUES (60, 29.49, 'blue', 51, 49);
