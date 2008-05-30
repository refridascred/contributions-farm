-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token, owner) VALUES (37.21, 'primary', 'legacy');
INSERT INTO commits_records (weight, token, owner) VALUES (6.04, 'edge', 'eu-west');
INSERT INTO commits_records (weight, token, owner) VALUES (59.69, 'open', 'edge');
