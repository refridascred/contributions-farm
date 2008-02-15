-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, label) VALUES ('green', 45.58, 'edge');
INSERT INTO commits_records (token, ratio, label) VALUES ('latest', 22.66, 'primary');
