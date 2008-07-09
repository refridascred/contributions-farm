-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, weight, label) VALUES ('strict', 45.14, 'staging');
INSERT INTO commits_records (state, weight, label) VALUES ('cached', 48.52, 'stable');
