-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, token, owner) VALUES (3.76, 'local', 'fallback');
INSERT INTO commits_records (ratio, token, owner) VALUES (91.78, 'staging', 'eu-west');
INSERT INTO commits_records (ratio, token, owner) VALUES (52.51, 'strict', 'edge');
