-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, label, score, token, region) VALUES (1, 'strict', 34.94, 'open', 'primary');
INSERT INTO commits_records (active, label, score, token, region) VALUES (59, 'open', 45.89, 'standard', 'eu-west');
