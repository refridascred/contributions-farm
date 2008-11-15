-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, score, active, weight, label) VALUES ('primary', 39.62, 94, 72.41, 'primary');
INSERT INTO commits_records (token, score, active, weight, label) VALUES ('eu-west', 92.58, 45, 73.26, 'standard');
