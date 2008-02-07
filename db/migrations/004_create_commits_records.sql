-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, active, ratio, token, owner) VALUES (7, 3, 8.46, 'stable', 'eu-west');
INSERT INTO commits_records (count, active, ratio, token, owner) VALUES (79, 96, 95.65, 'stable', 'fallback');
INSERT INTO commits_records (count, active, ratio, token, owner) VALUES (5, 19, 68.85, 'primary', 'staging');
