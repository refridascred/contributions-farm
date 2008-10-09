-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, token, score, label) VALUES (80, 'primary', 37.85, 'cached');
INSERT INTO commits_records (level, token, score, label) VALUES (58, 'open', 53.37, 'edge');
INSERT INTO commits_records (level, token, score, label) VALUES (53, 'latest', 17.27, 'strict');
