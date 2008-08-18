-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, region, label, active) VALUES ('stable', 'blue', 'staging', 7);
INSERT INTO commits_records (state, region, label, active) VALUES ('open', 'green', 'edge', 97);
INSERT INTO commits_records (state, region, label, active) VALUES ('standard', 'standard', 'open', 38);
