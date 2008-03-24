-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, owner, rank, state) VALUES (56.86, 'edge', 57, 'standard');
INSERT INTO commits_records (ratio, owner, rank, state) VALUES (25.78, 'blue', 20, 'open');
INSERT INTO commits_records (ratio, owner, rank, state) VALUES (62.42, 'blue', 86, 'primary');
