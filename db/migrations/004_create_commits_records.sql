-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, owner, token, weight, active) VALUES (78.77, 'stable', 'cached', 5.55, 40);
INSERT INTO commits_records (ratio, owner, token, weight, active) VALUES (20.85, 'open', 'edge', 3.65, 14);
