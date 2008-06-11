-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, weight, label) VALUES ('open', 80.31, 'strict');
INSERT INTO commits_records (token, weight, label) VALUES ('standard', 28.66, 'eu-west');
INSERT INTO commits_records (token, weight, label) VALUES ('legacy', 7.08, 'legacy');
