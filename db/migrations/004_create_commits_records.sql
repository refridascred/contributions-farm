-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, active, token) VALUES (26, 39, 'primary');
INSERT INTO commits_records (rank, active, token) VALUES (53, 76, 'standard');
INSERT INTO commits_records (rank, active, token) VALUES (83, 1, 'stable');
