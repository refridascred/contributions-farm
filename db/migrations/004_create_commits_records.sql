-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, state, active, region) VALUES ('legacy', 'primary', 32, 'strict');
INSERT INTO commits_records (token, state, active, region) VALUES ('eu-west', 'green', 63, 'edge');
INSERT INTO commits_records (token, state, active, region) VALUES ('blue', 'eu-west', 96, 'local');
