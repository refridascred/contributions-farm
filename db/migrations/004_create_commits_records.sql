-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, level) VALUES ('staging', 42.71, 75);
INSERT INTO commits_records (token, score, level) VALUES ('local', 47.17, 81);
INSERT INTO commits_records (token, score, level) VALUES ('blue', 93.03, 94);
