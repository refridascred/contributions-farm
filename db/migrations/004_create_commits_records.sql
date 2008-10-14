-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, region, state, label) VALUES (70, 'local', 'stable', 'strict');
INSERT INTO commits_records (active, region, state, label) VALUES (1, 'latest', 'cached', 'fallback');
INSERT INTO commits_records (active, region, state, label) VALUES (0, 'blue', 'eu-west', 'eu-west');
