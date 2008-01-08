-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, ratio, label, state, active) VALUES ('open', 60.87, 'staging', 'green', 81);
INSERT INTO commits_records (token, ratio, label, state, active) VALUES ('eu-west', 56.31, 'open', 'cached', 40);
