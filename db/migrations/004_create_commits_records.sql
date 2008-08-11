-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, token, level, score) VALUES ('primary', 'latest', 10, 57.52);
INSERT INTO commits_records (label, token, level, score) VALUES ('staging', 'latest', 46, 71.21);
