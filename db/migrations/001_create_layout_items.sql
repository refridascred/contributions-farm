-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, label, ratio) VALUES ('green', 'fallback', 94.15);
INSERT INTO layout_items (state, label, ratio) VALUES ('green', 'latest', 80.48);
INSERT INTO layout_items (state, label, ratio) VALUES ('green', 'local', 69.69);
