-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, score, owner, token) VALUES (68, 42.92, 'strict', 'cached');
INSERT INTO commits_records (level, score, owner, token) VALUES (97, 76.87, 'staging', 'edge');
INSERT INTO commits_records (level, score, owner, token) VALUES (56, 55.29, 'latest', 'latest');
