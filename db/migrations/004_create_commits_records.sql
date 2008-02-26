-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, active, token, owner) VALUES (20, 76, 'green', 'stable');
INSERT INTO commits_records (level, active, token, owner) VALUES (28, 84, 'fallback', 'primary');
INSERT INTO commits_records (level, active, token, owner) VALUES (4, 0, 'standard', 'green');
