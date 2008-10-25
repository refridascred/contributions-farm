-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, level, weight, label) VALUES (73, 2, 78.03, 'fallback');
INSERT INTO layout_items (active, level, weight, label) VALUES (84, 29, 27.18, 'primary');
INSERT INTO layout_items (active, level, weight, label) VALUES (30, 66, 66.92, 'strict');
