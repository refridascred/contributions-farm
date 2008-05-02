-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, state, token, owner, level) VALUES (9, 'edge', 'edge', 'green', 10);
INSERT INTO commits_records (count, state, token, owner, level) VALUES (61, 'open', 'primary', 'blue', 47);
