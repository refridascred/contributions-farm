-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token, label) VALUES (2.39, 'legacy', 'legacy');
INSERT INTO commits_records (weight, token, label) VALUES (44.19, 'latest', 'staging');
INSERT INTO commits_records (weight, token, label) VALUES (54.22, 'standard', 'strict');
