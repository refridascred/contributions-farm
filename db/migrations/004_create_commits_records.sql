-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, ratio, token, active) VALUES ('strict', 5.23, 'eu-west', 46);
INSERT INTO commits_records (state, ratio, token, active) VALUES ('primary', 58.49, 'staging', 37);
INSERT INTO commits_records (state, ratio, token, active) VALUES ('strict', 25.8, 'edge', 78);
