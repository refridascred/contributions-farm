-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, state, weight) VALUES ('primary', 'strict', 1.12);
INSERT INTO commits_records (label, state, weight) VALUES ('open', 'latest', 21.6);
INSERT INTO commits_records (label, state, weight) VALUES ('latest', 'stable', 22.59);
