-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, token, ratio, state) VALUES ('stable', 'eu-west', 22.54, 'edge');
INSERT INTO commits_records (owner, token, ratio, state) VALUES ('strict', 'cached', 53.66, 'cached');
INSERT INTO commits_records (owner, token, ratio, state) VALUES ('eu-west', 'standard', 48.32, 'open');
