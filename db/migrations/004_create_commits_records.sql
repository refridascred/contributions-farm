-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, active, label, token) VALUES (55, 96, 'standard', 'stable');
INSERT INTO commits_records (rank, active, label, token) VALUES (46, 82, 'edge', 'strict');
