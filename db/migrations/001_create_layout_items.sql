-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, state, level, active) VALUES (56.39, 'cached', 11, 6);
INSERT INTO layout_items (weight, state, level, active) VALUES (91.57, 'green', 23, 11);
INSERT INTO layout_items (weight, state, level, active) VALUES (81.3, 'local', 9, 42);
