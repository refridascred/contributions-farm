-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, active, state) VALUES (58, 9, 'open');
INSERT INTO layout_items (count, active, state) VALUES (23, 27, 'open');
INSERT INTO layout_items (count, active, state) VALUES (24, 62, 'staging');
