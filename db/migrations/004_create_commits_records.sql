-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, label, token, score, active) VALUES (39.28, 'eu-west', 'latest', 0.93, 19);
INSERT INTO commits_records (weight, label, token, score, active) VALUES (12.69, 'strict', 'green', 66.9, 26);
INSERT INTO commits_records (weight, label, token, score, active) VALUES (52.55, 'open', 'staging', 84.49, 10);
