-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, score, rank, label) VALUES (8, 19.85, 2, 'cached');
INSERT INTO commits_records (active, score, rank, label) VALUES (74, 30.95, 87, 'fallback');
INSERT INTO commits_records (active, score, rank, label) VALUES (98, 93.07, 58, 'standard');
