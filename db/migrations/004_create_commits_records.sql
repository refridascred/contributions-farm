-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, active, state, rank) VALUES ('fallback', 70, 'edge', 65);
INSERT INTO commits_records (token, active, state, rank) VALUES ('open', 92, 'strict', 79);
INSERT INTO commits_records (token, active, state, rank) VALUES ('local', 30, 'blue', 67);
