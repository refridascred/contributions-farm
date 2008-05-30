-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, active, label, state) VALUES ('blue', 93, 'primary', 'cached');
INSERT INTO commits_records (region, active, label, state) VALUES ('cached', 82, 'primary', 'latest');
INSERT INTO commits_records (region, active, label, state) VALUES ('green', 45, 'eu-west', 'strict');
