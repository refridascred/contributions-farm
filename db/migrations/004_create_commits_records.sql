-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, label, active, state) VALUES (41, 'stable', 27, 'legacy');
INSERT INTO commits_records (level, label, active, state) VALUES (67, 'green', 50, 'eu-west');
INSERT INTO commits_records (level, label, active, state) VALUES (7, 'latest', 19, 'open');
