-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, rank, state, active) VALUES (69, 72, 'strict', 13);
INSERT INTO commits_records (count, rank, state, active) VALUES (1, 44, 'open', 98);
INSERT INTO commits_records (count, rank, state, active) VALUES (17, 63, 'cached', 93);
