-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, count, state) VALUES ('open', 7, 'strict');
INSERT INTO layout_items (label, count, state) VALUES ('blue', 60, 'blue');
INSERT INTO layout_items (label, count, state) VALUES ('local', 35, 'green');
