-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, token, score, label) VALUES (19.06, 'stable', 45.79, 'stable');
INSERT INTO commits_records (ratio, token, score, label) VALUES (23.26, 'latest', 2.46, 'blue');
INSERT INTO commits_records (ratio, token, score, label) VALUES (19.84, 'local', 50.81, 'eu-west');
