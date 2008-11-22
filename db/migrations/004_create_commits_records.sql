-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, token, ratio) VALUES (94, 'eu-west', 52.53);
INSERT INTO commits_records (active, token, ratio) VALUES (25, 'fallback', 37.13);
INSERT INTO commits_records (active, token, ratio) VALUES (87, 'open', 89.69);
