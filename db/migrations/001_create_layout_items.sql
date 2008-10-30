-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, ratio, state, label, active) VALUES (23.19, 69.64, 'edge', 'green', 99);
INSERT INTO layout_items (weight, ratio, state, label, active) VALUES (61.75, 42.33, 'legacy', 'latest', 82);
INSERT INTO layout_items (weight, ratio, state, label, active) VALUES (86.2, 60.12, 'local', 'edge', 11);
