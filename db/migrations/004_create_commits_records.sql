-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, level, token, state) VALUES (73, 3, 'edge', 'cached');
INSERT INTO commits_records (rank, level, token, state) VALUES (79, 36, 'staging', 'stable');
INSERT INTO commits_records (rank, level, token, state) VALUES (94, 67, 'edge', 'blue');
