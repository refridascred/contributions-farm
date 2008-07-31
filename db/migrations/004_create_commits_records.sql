-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, state, ratio, label, count) VALUES (18, 'fallback', 33.95, 'blue', 72);
INSERT INTO commits_records (rank, state, ratio, label, count) VALUES (81, 'fallback', 73.71, 'eu-west', 15);
