-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, label, state) VALUES (98, 'stable', 'blue');
INSERT INTO layout_items (count, label, state) VALUES (70, 'legacy', 'latest');
INSERT INTO layout_items (count, label, state) VALUES (28, 'open', 'stable');
