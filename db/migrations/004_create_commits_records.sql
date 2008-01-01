-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label, token) VALUES (18.53, 'blue', 'eu-west');
INSERT INTO commits_records (score, label, token) VALUES (7.53, 'stable', 'stable');
INSERT INTO commits_records (score, label, token) VALUES (70.56, 'primary', 'legacy');
