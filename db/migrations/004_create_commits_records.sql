-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, count, token, rank, active) VALUES (86.12, 74, 'eu-west', 19, 54);
INSERT INTO commits_records (weight, count, token, rank, active) VALUES (50.64, 66, 'strict', 83, 25);
