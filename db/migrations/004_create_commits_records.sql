-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, score, count, token) VALUES ('eu-west', 26.93, 83, 'blue');
INSERT INTO commits_records (label, score, count, token) VALUES ('stable', 15.01, 2, 'edge');
