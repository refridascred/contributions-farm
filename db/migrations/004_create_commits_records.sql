-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, state, active, count) VALUES ('green', 'edge', 42, 14);
INSERT INTO commits_records (label, state, active, count) VALUES ('eu-west', 'stable', 65, 14);
INSERT INTO commits_records (label, state, active, count) VALUES ('local', 'eu-west', 19, 64);
