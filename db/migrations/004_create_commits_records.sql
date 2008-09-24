-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, active, state, level) VALUES ('primary', 91, 'fallback', 9);
INSERT INTO commits_records (token, active, state, level) VALUES ('fallback', 18, 'local', 28);
INSERT INTO commits_records (token, active, state, level) VALUES ('stable', 2, 'legacy', 17);
