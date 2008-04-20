-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, state, token, level) VALUES (80, 'primary', 'legacy', 34);
INSERT INTO commits_records (active, state, token, level) VALUES (48, 'eu-west', 'local', 22);
INSERT INTO commits_records (active, state, token, level) VALUES (79, 'edge', 'standard', 89);
