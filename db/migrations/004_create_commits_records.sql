-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, label, level, active, state) VALUES ('stable', 'cached', 47, 22, 'open');
INSERT INTO commits_records (owner, label, level, active, state) VALUES ('strict', 'local', 89, 84, 'cached');
INSERT INTO commits_records (owner, label, level, active, state) VALUES ('primary', 'cached', 21, 51, 'blue');
