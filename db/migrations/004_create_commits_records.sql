-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, label, active, token) VALUES (42, 'primary', 35, 'fallback');
INSERT INTO commits_records (rank, label, active, token) VALUES (86, 'staging', 11, 'blue');
INSERT INTO commits_records (rank, label, active, token) VALUES (73, 'primary', 4, 'standard');
