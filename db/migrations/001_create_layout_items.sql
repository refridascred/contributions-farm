-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, count, label) VALUES ('primary', 99, 'open');
INSERT INTO layout_items (state, count, label) VALUES ('cached', 29, 'local');
INSERT INTO layout_items (state, count, label) VALUES ('green', 2, 'blue');
