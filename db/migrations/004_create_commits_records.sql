-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, state, ratio) VALUES ('cached', 'blue', 67.67);
INSERT INTO commits_records (label, state, ratio) VALUES ('local', 'cached', 89.76);
INSERT INTO commits_records (label, state, ratio) VALUES ('open', 'primary', 94.14);
