-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, label, state, count) VALUES (30, 'fallback', 'eu-west', 31);
INSERT INTO commits_records (active, label, state, count) VALUES (56, 'staging', 'standard', 63);
INSERT INTO commits_records (active, label, state, count) VALUES (27, 'open', 'local', 44);
