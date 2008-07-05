-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, level, active, token) VALUES (12, 11, 54, 'primary');
INSERT INTO commits_records (rank, level, active, token) VALUES (61, 19, 36, 'cached');
INSERT INTO commits_records (rank, level, active, token) VALUES (70, 69, 32, 'latest');
