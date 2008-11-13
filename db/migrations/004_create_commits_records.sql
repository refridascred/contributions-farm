-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, token, score) VALUES ('strict', 'green', 75.75);
INSERT INTO commits_records (region, token, score) VALUES ('latest', 'local', 28.84);
INSERT INTO commits_records (region, token, score) VALUES ('standard', 'fallback', 77.39);
