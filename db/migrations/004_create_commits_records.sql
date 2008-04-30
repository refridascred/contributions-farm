-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, label) VALUES ('cached', 59.89, 'eu-west');
INSERT INTO commits_records (token, ratio, label) VALUES ('local', 80.33, 'primary');
