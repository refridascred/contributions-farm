-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, weight, state, label, rank) VALUES (67, 57.52, 'green', 'open', 41);
INSERT INTO commits_records (count, weight, state, label, rank) VALUES (76, 58.04, 'open', 'local', 2);
INSERT INTO commits_records (count, weight, state, label, rank) VALUES (82, 60.5, 'latest', 'eu-west', 54);
