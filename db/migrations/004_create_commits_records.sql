-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, active, region) VALUES ('green', 7, 'eu-west');
INSERT INTO commits_records (token, active, region) VALUES ('strict', 48, 'edge');
INSERT INTO commits_records (token, active, region) VALUES ('primary', 55, 'edge');
