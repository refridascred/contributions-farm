-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, state, label, ratio, token) VALUES ('staging', 'strict', 'stable', 5.77, 'eu-west');
INSERT INTO layout_items (owner, state, label, ratio, token) VALUES ('primary', 'standard', 'open', 8.53, 'fallback');
INSERT INTO layout_items (owner, state, label, ratio, token) VALUES ('edge', 'latest', 'edge', 31.79, 'fallback');
