-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, label, token) VALUES (50, 64, 'blue', 'primary');
INSERT INTO commits_records (rank, level, label, token) VALUES (83, 4, 'blue', 'blue');
INSERT INTO commits_records (rank, level, label, token) VALUES (56, 84, 'legacy', 'cached');
