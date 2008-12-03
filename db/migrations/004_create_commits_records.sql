-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, state) VALUES (8, 'latest');
INSERT INTO commits_records (active, state) VALUES (57, 'legacy');
INSERT INTO commits_records (active, state) VALUES (72, 'eu-west');
