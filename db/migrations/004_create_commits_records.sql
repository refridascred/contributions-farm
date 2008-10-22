-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, token, ratio, owner) VALUES ('stable', 'staging', 93.3, 'green');
INSERT INTO commits_records (label, token, ratio, owner) VALUES ('cached', 'staging', 19.92, 'blue');
