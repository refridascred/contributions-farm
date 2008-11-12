-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, active, token, label) VALUES (48, 75, 'latest', 'eu-west');
INSERT INTO commits_records (level, active, token, label) VALUES (72, 89, 'fallback', 'edge');
INSERT INTO commits_records (level, active, token, label) VALUES (13, 43, 'open', 'blue');
