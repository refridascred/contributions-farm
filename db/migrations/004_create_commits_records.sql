-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, active, state, ratio, rank) VALUES (0.09, 35, 'eu-west', 47.17, 0);
INSERT INTO commits_records (score, active, state, ratio, rank) VALUES (76.14, 79, 'edge', 76.32, 7);
