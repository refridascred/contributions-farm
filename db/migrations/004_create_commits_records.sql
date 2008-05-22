-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, ratio, label, token) VALUES (19.97, 40.09, 'eu-west', 'open');
INSERT INTO commits_records (score, ratio, label, token) VALUES (22.76, 98.3, 'eu-west', 'green');
