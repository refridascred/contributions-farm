-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, token, label, active, ratio) VALUES (80, 'eu-west', 'fallback', 85, 11.05);
INSERT INTO commits_records (count, token, label, active, ratio) VALUES (51, 'edge', 'green', 25, 79.73);
INSERT INTO commits_records (count, token, label, active, ratio) VALUES (52, 'staging', 'edge', 77, 81.92);
