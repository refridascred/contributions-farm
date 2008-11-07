-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, region, label, token) VALUES (94, 'fallback', 'blue', 'stable');
INSERT INTO commits_records (active, region, label, token) VALUES (93, 'blue', 'cached', 'legacy');
INSERT INTO commits_records (active, region, label, token) VALUES (4, 'strict', 'eu-west', 'green');
