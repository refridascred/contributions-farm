-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, token, label, score) VALUES (55.07, 'cached', 'green', 3.84);
INSERT INTO commits_records (ratio, token, label, score) VALUES (11.97, 'green', 'latest', 29.3);
