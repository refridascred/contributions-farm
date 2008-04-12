-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, region, label, state) VALUES (85, 'legacy', 'eu-west', 'stable');
INSERT INTO commits_records (active, region, label, state) VALUES (56, 'local', 'eu-west', 'local');
INSERT INTO commits_records (active, region, label, state) VALUES (70, 'green', 'edge', 'eu-west');
