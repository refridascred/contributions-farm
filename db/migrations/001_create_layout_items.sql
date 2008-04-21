-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, score, state, token, label) VALUES ('latest', 10.7, 'edge', 'eu-west', 'open');
INSERT INTO layout_items (region, score, state, token, label) VALUES ('edge', 78.16, 'local', 'eu-west', 'legacy');
