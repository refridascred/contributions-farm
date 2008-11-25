-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, owner, token, state) VALUES (13.02, 'primary', 'open', 'legacy');
INSERT INTO commits_records (ratio, owner, token, state) VALUES (43.84, 'eu-west', 'latest', 'edge');
INSERT INTO commits_records (ratio, owner, token, state) VALUES (6.61, 'open', 'open', 'green');
