-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token, label, ratio) VALUES (84.84, 'open', 'open', 5.18);
INSERT INTO commits_records (weight, token, label, ratio) VALUES (68.21, 'latest', 'cached', 78.72);
