-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, active, state) VALUES (83, 16, 'stable');
INSERT INTO commits_records (rank, active, state) VALUES (61, 85, 'standard');
INSERT INTO commits_records (rank, active, state) VALUES (17, 23, 'stable');
