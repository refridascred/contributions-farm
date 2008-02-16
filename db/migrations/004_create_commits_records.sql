-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, active, ratio, region, score) VALUES ('local', 51, 82.19, 'local', 75.87);
INSERT INTO commits_records (token, active, ratio, region, score) VALUES ('staging', 14, 63.25, 'local', 84.22);
