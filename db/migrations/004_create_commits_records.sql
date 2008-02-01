-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, level, active, token, owner) VALUES (31.0, 65, 7, 'fallback', 'cached');
INSERT INTO commits_records (ratio, level, active, token, owner) VALUES (29.82, 55, 80, 'fallback', 'standard');
