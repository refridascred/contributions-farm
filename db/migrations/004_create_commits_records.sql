-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, score, token, rank) VALUES (80, 55.46, 'latest', 95);
INSERT INTO commits_records (level, score, token, rank) VALUES (42, 7.52, 'local', 72);
INSERT INTO commits_records (level, score, token, rank) VALUES (27, 13.11, 'green', 22);
