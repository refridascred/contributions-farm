-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, state, label, level) VALUES (24, 'blue', 'legacy', 55);
INSERT INTO commits_records (rank, state, label, level) VALUES (84, 'edge', 'open', 47);
INSERT INTO commits_records (rank, state, label, level) VALUES (69, 'staging', 'cached', 71);
