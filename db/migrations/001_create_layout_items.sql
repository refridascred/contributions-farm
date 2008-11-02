-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, token, label, owner) VALUES ('cached', 'cached', 'green', 'open');
INSERT INTO layout_items (state, token, label, owner) VALUES ('stable', 'staging', 'fallback', 'fallback');
INSERT INTO layout_items (state, token, label, owner) VALUES ('green', 'cached', 'strict', 'edge');
