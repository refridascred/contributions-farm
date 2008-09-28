-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, token, level) VALUES (18, 'open', 40);
INSERT INTO commits_records (active, token, level) VALUES (63, 'legacy', 97);
INSERT INTO commits_records (active, token, level) VALUES (84, 'edge', 42);
