-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, weight, owner, token, ratio) VALUES ('blue', 72.21, 'open', 'open', 57.95);
INSERT INTO commits_records (label, weight, owner, token, ratio) VALUES ('stable', 6.5, 'green', 'eu-west', 33.2);
INSERT INTO commits_records (label, weight, owner, token, ratio) VALUES ('latest', 35.53, 'latest', 'eu-west', 56.22);
