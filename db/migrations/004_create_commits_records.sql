-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, ratio, region, token) VALUES ('strict', 54.84, 'cached', 'open');
INSERT INTO commits_records (label, ratio, region, token) VALUES ('strict', 18.81, 'green', 'latest');
