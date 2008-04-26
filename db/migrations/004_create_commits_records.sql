-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, active, region, token) VALUES (82, 44, 'stable', 'primary');
INSERT INTO commits_records (rank, active, region, token) VALUES (91, 25, 'strict', 'standard');
