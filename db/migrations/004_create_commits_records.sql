-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, token, label, level) VALUES (22.5, 'local', 'open', 99);
INSERT INTO commits_records (score, token, label, level) VALUES (53.69, 'fallback', 'eu-west', 19);
INSERT INTO commits_records (score, token, label, level) VALUES (69.17, 'edge', 'open', 87);
