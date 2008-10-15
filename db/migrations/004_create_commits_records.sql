-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token, active) VALUES (46.91, 'green', 55);
INSERT INTO commits_records (weight, token, active) VALUES (45.09, 'open', 33);
INSERT INTO commits_records (weight, token, active) VALUES (92.76, 'green', 67);
