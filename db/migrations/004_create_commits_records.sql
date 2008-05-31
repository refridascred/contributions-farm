-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, state, count, weight, label) VALUES ('green', 'eu-west', 30, 23.57, 'green');
INSERT INTO commits_records (owner, state, count, weight, label) VALUES ('fallback', 'primary', 18, 93.43, 'green');
INSERT INTO commits_records (owner, state, count, weight, label) VALUES ('open', 'cached', 13, 19.83, 'edge');
