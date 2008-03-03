-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, count, active, state) VALUES (24.06, 93, 54, 'eu-west');
INSERT INTO commits_records (ratio, count, active, state) VALUES (38.79, 91, 17, 'eu-west');
INSERT INTO commits_records (ratio, count, active, state) VALUES (52.0, 80, 72, 'open');
