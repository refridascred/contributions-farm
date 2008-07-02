-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, score, token, state) VALUES (87, 52.53, 'edge', 'standard');
INSERT INTO commits_records (count, score, token, state) VALUES (17, 77.11, 'eu-west', 'open');
INSERT INTO commits_records (count, score, token, state) VALUES (36, 87.1, 'primary', 'standard');
