-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, count, token, label) VALUES (63.34, 90, 'legacy', 'eu-west');
INSERT INTO commits_records (score, count, token, label) VALUES (64.08, 87, 'stable', 'latest');
INSERT INTO commits_records (score, count, token, label) VALUES (98.33, 62, 'local', 'staging');
