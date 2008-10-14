-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, state, region) VALUES (13, 'fallback', 'green');
INSERT INTO commits_records (active, state, region) VALUES (80, 'green', 'stable');
INSERT INTO commits_records (active, state, region) VALUES (50, 'cached', 'latest');
