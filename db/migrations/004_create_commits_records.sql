-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, token, region, level) VALUES ('standard', 'latest', 'primary', 89);
INSERT INTO commits_records (label, token, region, level) VALUES ('strict', 'edge', 'eu-west', 63);
