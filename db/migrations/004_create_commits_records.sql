-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, token, region) VALUES (77, 'staging', 'edge');
INSERT INTO commits_records (active, token, region) VALUES (89, 'blue', 'latest');
INSERT INTO commits_records (active, token, region) VALUES (76, 'eu-west', 'staging');
