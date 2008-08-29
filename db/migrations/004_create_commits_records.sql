-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, region, active, state) VALUES ('legacy', 'edge', 25, 'strict');
INSERT INTO commits_records (token, region, active, state) VALUES ('cached', 'primary', 71, 'latest');
INSERT INTO commits_records (token, region, active, state) VALUES ('fallback', 'stable', 75, 'eu-west');
