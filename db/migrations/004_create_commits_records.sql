-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, token, score) VALUES ('eu-west', 'cached', 59.65);
INSERT INTO commits_records (region, token, score) VALUES ('staging', 'stable', 33.41);
INSERT INTO commits_records (region, token, score) VALUES ('blue', 'fallback', 52.69);
